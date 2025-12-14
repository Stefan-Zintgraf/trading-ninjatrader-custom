# NinjaTrader Desktop API - AI Assistant Guide

This directory contains a local, offline knowledge base of the **NinjaTrader Desktop API**.

## Source Information
**Original Source**: [https://developer.ninjatrader.com/docs/desktop](https://developer.ninjatrader.com/docs/desktop)
All content in this knowledge base is derived from the official documentation.

## How to use this Documentation

### 1. Primary Knowledge Source: `MD/` Folder
**Step 1**: Always search the `MD` directory in this workspace first.
This folder contains the full documentation converted to Markdown.

*   **Structure**: Flat directory.
*   **Filenames**: Based on the URL slug (e.g., `strategy.md`, `onbarupdate.md`).

### 2. Navigating Contexts
At the top of each Markdown file, you will find a **Contexts** header.
Example:
```markdown
**Contexts**:
- [Strategy](./strategy.md) > [OnBarUpdate](./onbarupdate.md)
```
Use these links to understand where the current class or method fits into the larger API hierarchy (e.g., understanding that `OnBarUpdate` is part of the `Strategy` lifecycle).

### 3. Finding Class/Method Details
*   To find a class: Look for `ClassName.md` (e.g., `chartcontrol.md`).
*   To find a method: Look for `MethodName.md` (e.g., `enterlong.md`).
*   If a file is not found by name, search the content of related files (e.g., properties might be inside the class file).
