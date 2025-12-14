const fs = require('fs-extra');
const path = require('path');

const INPUT_FILE = path.join(__dirname, 'debug_hierarchy.json');
const OUTPUT_FILE = path.join(__dirname, 'url_to_paths.json');

(async () => {
    try {
        const rows = await fs.readJson(INPUT_FILE);
        // Map of URL -> Array of Breadcrumbs
        const urlMap = {};

        let stack = []; // Stores objects {text, url}

        rows.forEach(row => {
            const indent = Math.max(row.paddingLeft || 0, row.marginLeft || 0);

            // Calculate level
            const level = Math.round(indent / 20);

            // Rebuild stack
            stack[level] = { text: row.text, url: row.link };
            stack.length = level + 1;

            if (row.link) {
                let u;
                try {
                    u = new URL(row.link);
                    u.hash = '';
                } catch (e) { return; }

                const fullUrl = u.href;
                if (fullUrl.includes('/docs/desktop')) {

                    // Generate Breadcrumb with Links
                    const pathStr = stack.map(item => {
                        if (item && item.url && item.url.includes('/docs/desktop')) {
                            const parts = new URL(item.url).pathname.split('/');
                            let name = parts[parts.length - 1];
                            if (!name) name = 'index';
                            return `[${item.text}](./${name}.md)`;
                        } else {
                            return item ? item.text : '';
                        }
                    }).join(' > ');

                    if (!urlMap[fullUrl]) {
                        urlMap[fullUrl] = [];
                    }
                    // Avoid duplicate paths
                    if (!urlMap[fullUrl].includes(pathStr)) {
                        urlMap[fullUrl].push(pathStr);
                    }
                }
            }
        });

        // Convert to array or keep object? Object is easier for lookup.
        await fs.writeJson(OUTPUT_FILE, urlMap, { spaces: 2 });
        console.log(`Mapped paths for ${Object.keys(urlMap).length} unique URLs.`);

        // Check for multiples
        let multiples = 0;
        for (let k in urlMap) {
            if (urlMap[k].length > 1) {
                multiples++;
                if (multiples < 5) console.log(`Multiple paths for ${k}:`, urlMap[k]);
            }
        }
        console.log(`Found ${multiples} pages with multiple parent contexts.`);

    } catch (e) { console.error(e); }
})();
