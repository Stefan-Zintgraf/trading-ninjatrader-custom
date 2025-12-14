const fs = require('fs-extra');
const path = require('path');

const OUTPUT_DIR = path.join(__dirname, 'MD');
const MAP_FILE = path.join(__dirname, 'url_to_paths.json');

(async () => {
    try {
        if (!await fs.pathExists(MAP_FILE)) {
            console.error('url_to_paths.json missing!');
            return;
        }

        const urlMap = await fs.readJson(MAP_FILE);
        const files = await fs.readdir(OUTPUT_DIR);

        console.log(`Scanning ${files.length} files in output...`);

        let updated = 0;

        for (const file of files) {
            if (!file.endsWith('.md')) continue;

            const filePath = path.join(OUTPUT_DIR, file);
            let content = await fs.readFile(filePath, 'utf8');

            // Remove existing header if present
            // Regex for **Path**: ... or **Contexts**: ...
            content = content.replace(/^\*\*Path\*\*:[^\n]+\n\n/, '');
            content = content.replace(/^\*\*Contexts\*\*:[^\n]+\n(\s*-\s+[^\n]+\n)+\n/, '');

            // Determine URL from filename
            // This is tricky. We used "basename" which matches the map logic: 
            // map used `item.url.split('/').pop()`
            // So we can try to reverse-lookup or just assume `https://developer.ninjatrader.com/docs/desktop/${basename without md}` works

            const baseName = path.basename(file, '.md');
            // We need to match it against the keys in urlMap. 
            // Since keys are full URLs, let's find the matching key.
            const targetUrl = `https://developer.ninjatrader.com/docs/desktop/${baseName}`;

            // Handle index edge case
            // If filename 'index', url ends in /index usually
            // but let's just use direct lookup

            let paths = urlMap[targetUrl];

            if (!paths) {
                // Try fuzzy matching?
                // The map key might differ slightly?
                // Let's assume strict naming for now.
            }

            if (paths && paths.length > 0) {
                let header = "";
                if (paths.length === 1) {
                    header = `**Path**: ${paths[0]}\n\n`;
                } else {
                    header = `**Contexts**:\n${paths.map(p => `- ${p}`).join('\n')}\n\n`;
                }

                const newContent = header + content;
                await fs.writeFile(filePath, newContent);
                updated++;
            }
        }

        console.log(`Updated metadata for ${updated} files.`);

    } catch (e) { console.error(e); }
})();
