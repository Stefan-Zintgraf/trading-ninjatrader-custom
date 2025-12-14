@echo off
echo Starting NinjaTrader Documentation Scraper (2-Step Pipeline)...

echo Step 1: Extracting Hierarchy...
node scrape_hierarchy.js
if %errorlevel% neq 0 (
    echo Hierarchy extraction failed!
    pause
    exit /b %errorlevel%
)

echo Step 2: Mapping Paths...
node map_hierarchy.js
if %errorlevel% neq 0 (
    echo Path mapping failed!
    pause
    exit /b %errorlevel%
)

echo Step 3: Downloading Content (Clean)...
node download_content.js
if %errorlevel% neq 0 (
    echo Content download failed!
    pause
    exit /b %errorlevel%
)

echo Step 4: Injecting Metadata contexts...
node inject_metadata.js
if %errorlevel% neq 0 (
    echo Metadata injection failed!
    pause
    exit /b %errorlevel%
)

echo Scraping Complete!
pause
