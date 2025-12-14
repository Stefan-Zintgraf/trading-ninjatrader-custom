**Path**: [ChartAnchor](./chartanchor.md) > [IsNinjaScriptDrawn](./isninjascriptdrawn.md)

# IsNinjaScriptDrawn

# IsNinjaScriptDrawn

## [Definition](./isninjascriptdrawn.md)

Indicates if the chart anchor was drawn by a **NinjaScript** object (such as an indicator or strategy).

## [Property Value](./isninjascriptdrawn.md)

A bool value which returns true if the object was drawn by another **NinjaScript** object; otherwise false. This property is read\-only.

## [Syntax](./isninjascriptdrawn.md)

`<chartanchor>.IsNinjaScriptDrawn`

## [Examples](./isninjascriptdrawn.md)

```csharp
//unlocks the NinjaScript drawn object and allows the user to modify the anchor, while the NinjaScript object still 'owns' the object
protected override void OnBarUpdate()
{
     foreach(IDrawingTool dt in DrawObjects)
         {
           DrawingTools.Line sampleLine = dt as DrawingTools.Line;
           
           if (sampleLine != null && sampleLine.StartAnchor.IsNinjaScriptDrawn)
           {
               sampleLine.IsLocked = false;
               Print(sampleLine.StartAnchor.ToString());
           }
         }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isninjascriptdrawn.md)
*   [Property Value](./isninjascriptdrawn.md)
*   [Syntax](./isninjascriptdrawn.md)
*   [Examples](./isninjascriptdrawn.md)