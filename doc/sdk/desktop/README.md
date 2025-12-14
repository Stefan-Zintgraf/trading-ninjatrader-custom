# NinjaTrader Documentation Scraper

This tool creates an offline knowledge base of the [NinjaTrader Desktop Documentation](https://developer.ninjatrader.com/docs/desktop) by converting it to Markdown.

## Prerequisites
- Node.js (v12+)
- Chrome/Chromium installed

## Installation
1. Navigate to this directory.
2. Run `npm install` to install dependencies (`puppeteer-core`, `fs-extra`, `turndown`).

## Usage

## Usage
The process is split into a robust pipeline to handle hierarchy and multi-parent pages:

### 1. Extract Hierarchy
Traverses the dynamic sidebar to capture the full tree structure and all "Breadcrumb" paths.
```bash
node scrape_hierarchy.js
```

### 2. Map Paths
Aggregates all unique paths for every page (handling multiple parents).
```bash
node map_hierarchy.js
```

### 3. Download Clean Content
Downloads the raw content and converts it to Markdown (without metadata).
```bash
node download_content.js
```

### 4. Inject Metadata
Iterates through the downloaded files and injects the "Contexts" header (Breadcrumbs) into each one.
```bash
node inject_metadata.js
```

## Automation
You can run the full pipeline in one go:
```bash
run_scraper.bat
```

## Output
- `output/*.md`: Markdown files for each page.
- `output/images/*`: Downloaded images.

## Automation
You can run `run_scraper.bat` to execute both steps sequentially.
