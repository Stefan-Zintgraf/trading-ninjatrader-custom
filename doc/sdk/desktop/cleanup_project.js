const fs = require('fs-extra');
const path = require('path');

const LEGACY_DIR = path.join(__dirname, '_legacy');
const OUTPUT_DIR = path.join(__dirname, 'MD');

const FILES_TO_MOVE = [
    'scrape.js',
    'scrape_fresh.js',
    'scrape_links.js',
    'scrape_step1.js',
    'scrape_step2.js',
    'inspect_sidebar.js',
    'process_hierarchy.js',
    'check_collisions.js',
    'check_metadata.js',
    'links.json',
    'links_with_metadata.json', // Now obsolete
    'test-launch.js',
    'test_fs.js',
    'test_pup.js',
    'test_turn.js',
    'test_turn_init.js'
];

const EXTENSIONS_TO_MOVE = ['.log'];

(async () => {
    try {
        await fs.ensureDir(LEGACY_DIR);
        console.log(`Created legacy directory: ${LEGACY_DIR}`);

        // 1. Move root files
        const rootFiles = await fs.readdir(__dirname);
        for (const file of rootFiles) {
            const filePath = path.join(__dirname, file);
            const ext = path.extname(file);

            if (FILES_TO_MOVE.includes(file) || EXTENSIONS_TO_MOVE.includes(ext)) {
                const dest = path.join(LEGACY_DIR, file);
                await fs.move(filePath, dest, { overwrite: true });
                console.log(`Moved to legacy: ${file}`);
            }
        }

        // 2. Cleanup Output (HTML, CSS)
        if (await fs.pathExists(OUTPUT_DIR)) {
            const outFiles = await fs.readdir(OUTPUT_DIR);
            for (const file of outFiles) {
                const filePath = path.join(OUTPUT_DIR, file);
                const stat = await fs.stat(filePath);

                if (stat.isFile() && file.endsWith('.html')) {
                    await fs.remove(filePath);
                    console.log(`Deleted: output/${file}`);
                } else if (stat.isDirectory() && (file === 'css' || file === 'MD.step1' || file === 'MD.step2')) {
                    await fs.remove(filePath);
                    console.log(`Deleted folder: output/${file}`);
                }
            }
        }

        console.log('Cleanup complete.');

    } catch (e) {
        console.error('Cleanup failed:', e);
    }
})();
