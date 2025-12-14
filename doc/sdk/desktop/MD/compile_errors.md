**Path**: [Compile Error Codes](./compile_error_codes.md) > [Compile Errors](./compile_errors.md)

# Compile Errors

# Compile Errors

## [When compiling a custom indicator or strategy it is possible and likely that you will generate compile errors](./compile_errors.md)

*   NinjaTrader will compile ALL **NinjaScript** files NOT only the file you are working on.
*   A list of compile errors for all files will be displayed in the lower portion of the **NinjaScript Editor**.
*   Double click on an error to load the problem file and highlight the problem area.
*   Click on the error code to bring up Help Documentation on a specific error.
*   Right click on the error to exclude the problem file from compilation (see the section on [Excluding a script from compilation](./ninjascript_explorer.md) for more information).

## [The image below illustrates a compile error](./compile_errors.md)

1.  Section where compile errors are displayed. Errors in the current loaded file are color coded a light color while errors in other files have a darker color code.
2.  The file that contains the error.
3.  A description of the error.
4.  A error code link that will open the Help Guide with any relevant error code information.
5.  Line number and column number of the error.
6.  Error is underlined with a red wavy line.

The error highlighted by icon (6) below shows that the expression is not closed with a semicolon. The expression should be:

```csharp
double myValue = SMA(20)[0];

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![NS_Editor_4](https://cdn.sanity.io/images/1hlwceal/production/892d3658dbc83c34144c8214eb4b12e6ae241182-898x440.png)

#### ON THIS PAGE

*   [When compiling a custom indicator or strategy it is possible and likely that you will generate compile errors](./compile_errors.md)
*   [The image below illustrates a compile error](./compile_errors.md)