**Path**: [ChartAnchor](./chartanchor.md) > [IsGlobalDrawingTool](./isglobaldrawingtool.md)

# IsGlobalDrawingTool

# IsGlobalDrawingTool

## [Definition](./isglobaldrawingtool.md)

Indicates if the drawing tool is currently set as a Global Drawing object. Global draw objects display on any chart which matches the parent chart's underlying instrument.

## [Property Value](./isglobaldrawingtool.md)

A bool value which returns true if the drawing tool is currently attached as a global drawing object; otherwise false.

## [Syntax](./isglobaldrawingtool.md)

`IsGlobalDrawingTool`

## [Examples](./isglobaldrawingtool.md)

```csharp
public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
   // do not interact if attached to global chart
   if (IsGlobalDrawingTool)
     return;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isglobaldrawingtool.md)
*   [Property Value](./isglobaldrawingtool.md)
*   [Syntax](./isglobaldrawingtool.md)
*   [Examples](./isglobaldrawingtool.md)