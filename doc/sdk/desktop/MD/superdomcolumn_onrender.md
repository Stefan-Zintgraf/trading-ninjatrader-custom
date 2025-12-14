**Path**: [SuperDOM Column](./superdom_column.md) > [OnRender()](./superdomcolumn_onrender.md)

# OnRender()

# OnRender()

## [Definition](./superdomcolumn_onrender.md)

Used to draw custom content to the SuperDOM Column, such as a Grid.

This method is called during the following conditions:

*   The SuperDOM is centered (either automatically or when the user presses the Center button)
*   The SuperDOM is scrolled
*   All accounts are disconnected
*   A simulation account is reset
*   A position is updated
*   The user changes the SuperDOM's properties through the Properties menu
*   The SuperDOM first loads (e.g. restoring from a workspace)
*   The user changes the PnL display unit by clicking on the Position display
*   The height/width of the SuperDOM window changes
*   A user resizes the content area by dragging the splitter between price ladder and the columns

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

While similar to a Chart Indicator's [OnRender()](./onrender.md) method, the SuperDOM Column uses [WPF Drawing Context](https://msdn.microsoft.com/en-us/library/system.windows.media.drawingcontext(v=vs.110).aspx) class, rather than the SharpDX library used for [chart rendering](./rendering.md). Concepts between these two methods are guaranteed to be different.

## [Method Return Value](./superdomcolumn_onrender.md)

This method does not return a value.

## [Syntax](./superdomcolumn_onrender.md)

You must override the method in your SuperDOM column with the following syntax:

`protected override void OnRender(DrawingContext dc, double renderWidth) { }`

## [Parameters](./superdomcolumn_onrender.md)

dc

The drawing context for the column

renderWidth

The rendering width for the column

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In order to force OnRender() to be called under a specific condition, call the OnPropertyChanged() method which will force the entire column to repaint. This approach should be used instead of calling OnRender() directly.

## [Examples](./superdomcolumn_onrender.md)

```csharp
protected override void OnRender(DrawingContext dc, double renderWidth)
{
  // Rendering logic for our column
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./superdomcolumn_onrender.md)
*   [Method Return Value](./superdomcolumn_onrender.md)
*   [Syntax](./superdomcolumn_onrender.md)
*   [Parameters](./superdomcolumn_onrender.md)
*   [Examples](./superdomcolumn_onrender.md)