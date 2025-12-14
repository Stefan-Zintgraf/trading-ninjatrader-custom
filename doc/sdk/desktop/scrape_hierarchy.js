const puppeteer = require('puppeteer-core');
const fs = require('fs-extra');
const path = require('path');

const CHROME_PATH = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
const OUTPUT_FILE = path.join(__dirname, 'debug_hierarchy.json');

const delay = (ms) => new Promise(resolve => setTimeout(resolve, ms));

(async () => {
    console.log("Starting...");
    const browser = await puppeteer.launch({ executablePath: CHROME_PATH, headless: true });
    const page = await browser.newPage();

    try {
        console.log("Navigating...");
        await page.goto('https://developer.ninjatrader.com/docs/desktop', { waitUntil: 'networkidle0', timeout: 60000 });

        console.log("Expanding...");
        let loops = 0;
        let expanded = true;
        while (expanded && loops < 50) {
            expanded = false;
            loops++;
            // Expand strategy
            const btns = await page.$$('.left-pane img[src*="expand_more_right"]');
            for (let i = 0; i < btns.length; i++) {
                try {
                    const btn = btns[i];
                    const visible = await btn.evaluate(node => {
                        const r = node.getBoundingClientRect();
                        return r.width > 0 && r.height > 0;
                    });
                    if (visible) {
                        await btn.click();
                        expanded = true;
                        // await delay(50); // Fast clicks
                    }
                } catch (e) { }
            }
            if (expanded) {
                console.log(`  Expanded loop ${loops}`);
                await delay(2000); // Allow render
            }
        }

        console.log("Extracting rows...");
        const rows = await page.evaluate(() => {
            const container = document.querySelector('.left-pane');
            if (!container) return [];

            const results = [];
            const walker = document.createTreeWalker(container, NodeFilter.SHOW_TEXT, null, false);
            let node;
            while (node = walker.nextNode()) {
                if (node.textContent.trim().length > 1) {
                    const el = node.parentElement;
                    const rect = el.getBoundingClientRect();
                    if (rect.height > 0 && rect.width > 0) {
                        const style = window.getComputedStyle(el);
                        // Find potential link
                        const linkEl = el.closest('a');

                        // We need the PADDING that determines hierarchy.
                        // Sometimes it's on the 'mat-tree-node' parent, not the text span.
                        const treeNode = el.closest('mat-tree-node') || el.closest('div[role="treeitem"]');
                        let padding = parseFloat(style.paddingLeft || '0');
                        let margin = parseFloat(style.marginLeft || '0');

                        if (treeNode) {
                            const ts = window.getComputedStyle(treeNode);
                            // If the text has 0 padding, maybe the treeNode has it?
                            // Usually mat-tree uses padding-left on the node
                            padding = parseFloat(ts.paddingLeft || '0');
                            margin = parseFloat(ts.marginLeft || '0');
                        }

                        results.push({
                            text: node.textContent.trim(),
                            top: rect.top,
                            paddingLeft: padding,
                            marginLeft: margin,
                            link: linkEl ? linkEl.href : null,
                            tag: el.tagName
                        });
                    }
                }
            }

            results.sort((a, b) => a.top - b.top);

            // Dedupe
            const unique = [];
            if (results.length > 0) unique.push(results[0]);

            for (let i = 1; i < results.length; i++) {
                const prev = unique[unique.length - 1];
                const curr = results[i];
                if (Math.abs(curr.top - prev.top) > 5) {
                    unique.push(curr);
                }
            }
            return unique;
        });

        await fs.writeJson(OUTPUT_FILE, rows, { spaces: 2 });
        console.log(`Saved ${rows.length} rows to ${OUTPUT_FILE}`);

    } catch (e) { console.error(e); }
    await browser.close();
})();
