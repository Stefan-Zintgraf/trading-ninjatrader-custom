const puppeteer = require('puppeteer-core');
const fs = require('fs-extra');
const path = require('path');
const url = require('url');
const TurndownService = require('turndown');

const OUTPUT_DIR = path.join(__dirname, 'MD');
const CHROME_PATH = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
// We rely on the map file which contains all unique URLs as keys
const LINKS_FILE = path.join(__dirname, 'url_to_paths.json');

const delay = (ms) => new Promise(resolve => setTimeout(resolve, ms));

async function downloadContent() {
    console.log('Starting Clean Content Download...');

    if (!await fs.pathExists(LINKS_FILE)) {
        console.error('url_to_paths.json not found!');
        return;
    }

    const mapData = await fs.readJson(LINKS_FILE);
    // Keys are the URLs
    const uniqueUrls = Object.keys(mapData);
    console.log(`Loaded ${uniqueUrls.length} unique URLs to download.`);

    await fs.ensureDir(OUTPUT_DIR);

    const browser = await puppeteer.launch({
        executablePath: CHROME_PATH,
        headless: true,
        args: ['--no-sandbox', '--disable-setuid-sandbox']
    });
    const page = await browser.newPage();

    const turndownService = new TurndownService({
        headingStyle: 'atx',
        codeBlockStyle: 'fenced'
    });

    // Check resume/limit
    const limitIndex = process.argv.indexOf('--limit');
    let limit = uniqueUrls.length;
    if (limitIndex !== -1 && process.argv[limitIndex + 1]) {
        limit = parseInt(process.argv[limitIndex + 1], 10);
        console.log(`Limiting to first ${limit} pages.`);
    }

    const urlsToScrape = uniqueUrls.slice(0, limit);

    for (let i = 0; i < urlsToScrape.length; i++) {
        const link = urlsToScrape[i];
        console.log(`[${i + 1}/${urlsToScrape.length}] Processing: ${link}`);

        try {
            const pageName = link.split('/').pop() || 'index';
            const fileName = `${pageName}.md`;
            const filePath = path.join(OUTPUT_DIR, fileName);

            // optimization: Skip if exists AND looks valid (size > 100 bytes)
            // But user might want refresh. 
            // For now, let's skip to speed up the "Second Iteration" idea
            if (await fs.pathExists(filePath)) {
                const stats = await fs.stat(filePath);
                if (stats.size > 200) {
                    // console.log(`  Skipping (exists): ${fileName}`);
                    // continue;
                }
            }

            await page.goto(link, { waitUntil: 'networkidle0', timeout: 45000 });
            await page.waitForSelector('h1', { timeout: 10000 }).catch(() => { });

            // === ASSET SCRAPING ===
            const images = await page.evaluate(() => {
                return Array.from(document.querySelectorAll('app-doc-viewer img')).map(img => img.src);
            });

            const imgDir = path.join(OUTPUT_DIR, 'images');
            await fs.ensureDir(imgDir);
            const imgMap = {};

            for (let j = 0; j < images.length; j++) {
                const imgSrc = images[j];
                try {
                    let safeName = `img_${j}`;
                    const urlObj = new URL(imgSrc);
                    if (imgSrc.includes('_next/image')) {
                        const realUrl = urlObj.searchParams.get('url');
                        if (realUrl) {
                            const realBase = path.basename(decodeURIComponent(realUrl)).split('?')[0];
                            safeName = `${j}_${realBase}`;
                        } else {
                            safeName = `${j}_next_image`;
                        }
                    } else {
                        safeName = `${j}_${path.basename(urlObj.pathname)}`;
                    }
                    if (!path.extname(safeName)) safeName += '.png';

                    const imgPath = path.join(imgDir, safeName);
                    // Download if not exists
                    if (!await fs.pathExists(imgPath)) {
                        const imgBufStr = await page.evaluate(async (u) => {
                            const res = await fetch(u);
                            const blob = await res.blob();
                            return new Promise((resolve) => {
                                const reader = new FileReader();
                                reader.onloadend = () => resolve(reader.result);
                                reader.readAsDataURL(blob);
                            });
                        }, imgSrc);
                        const matches = imgBufStr.match(/^data:([A-Za-z-+\/]+);base64,(.+)$/);
                        if (matches) await fs.writeFile(imgPath, Buffer.from(matches[2], 'base64'));
                    }
                    imgMap[imgSrc] = `images/${safeName}`;
                } catch (e) { }
            }

            // === CONTENT EXTRACTION ===
            const htmlContent = await page.evaluate((imgMap) => {
                const h1 = document.querySelector('h1');
                if (!h1) return null;
                const contentNode = h1.parentElement;

                if (!contentNode) return null;
                const clone = contentNode.cloneNode(true);
                clone.querySelectorAll('img').forEach(img => {
                    if (imgMap[img.src]) {
                        img.src = imgMap[img.src];
                        img.removeAttribute('srcset');
                    }
                });
                clone.querySelectorAll('a[href]').forEach(a => {
                    const href = a.href;
                    if (href.includes('/docs/desktop')) {
                        const parts = new URL(href).pathname.split('/');
                        let name = parts[parts.length - 1];
                        if (!name) name = 'index';
                        a.href = `./${name}.md`;
                    }
                });
                clone.querySelectorAll('script, style').forEach(el => el.remove());
                return clone.innerHTML;
            }, imgMap);

            if (htmlContent) {
                const markdown = turndownService.turndown(htmlContent);
                const title = await page.evaluate(() => {
                    const h1 = document.querySelector('h1');
                    return h1 ? h1.innerText : '';
                });

                // NO METADATA INJECTION HERE
                const finalMd = `# ${title}\n\n${markdown}`;
                await fs.writeFile(filePath, finalMd);
                console.log(`  Saved ${fileName}`);
            }

        } catch (e) {
            console.error(`  Failed ${link}: ${e.message}`);
        }
        await delay(300); // Politeness delay
    }
    await browser.close();
}

downloadContent();
