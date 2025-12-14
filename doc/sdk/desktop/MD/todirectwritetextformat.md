**Path**: [SimpleFont](./simplefont.md) > [ToDirectWriteTextFormat()](./todirectwritetextformat.md)

# ToDirectWriteTextFormat()

# ToDirectWriteTextFormat()

## [Definition](./todirectwritetextformat.md)

Converts a **SimpleFont** object to a **SharpDX** compatible font which can be used for chart rendering.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For more information please see the educational resource on [Using SharpDX for Custom Chart Rendering](./using_sharpdx_for_custom_chart_rendering.md).

## [Method Return Value](./todirectwritetextformat.md)

A **DirectWrite.TextFormat** object

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

The returned DirectWrite.TextFormat object should be disposed of immediately when finished drawing text.

## [Syntax](./todirectwritetextformat.md)

`<simplefont>.ToDirectWriteTextFormat()`

## [Examples](./todirectwritetextformat.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Set text to chart label simple font object
   SharpDX.DirectWrite.TextFormat textFormat = chartControl.Properties.LabelFont.ToDirectWriteTextFormat();
 
   // use the textFormat in a RenderTarget.DrawText() or DrawTextLayout() method
 
   // do not forget to dispose text format when finished
   textFormat.Dispose();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./todirectwritetextformat.md)
*   [Method Return Value](./todirectwritetextformat.md)
*   [Syntax](./todirectwritetextformat.md)
*   [Examples](./todirectwritetextformat.md)