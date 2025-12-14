**Path**: [Chart Style](./chart_style.md) > [TransformBrush()](./transformbrush.md)

# TransformBrush()

# TransformBrush()

## [Definition](./transformbrush.md)

Scales a non\-solid color brush used for rendering the chart style to properly display in NinjaTrader.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method has no impact on solid color brushes.  You would only need to pass in either a linear or radial gradient brush.

## [Method Return Value](./transformbrush.md)

This method does not return a value.

## [Syntax](./transformbrush.md)

`TransformBrush(SharpDX.Direct2D1.Brush brush, RectangleF rect)`

## [Method Parameters](./transformbrush.md)

Parameter

Description

brush

A [SharpDX.Direct2D1.Brush](./sharpdx_direct2d1_brush.md) object representing the brush used to render

rect

A [RectangleF](https://msdn.microsoft.com/en-us/library/system.drawing.rectanglef%28v=vs.110%29.aspx) structure representing the rectangle to be rendered

## [Examples](./transformbrush.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)
{
		TransformBrush(brush, rect);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./transformbrush.md)
*   [Method Return Value](./transformbrush.md)
*   [Syntax](./transformbrush.md)
*   [Method Parameters](./transformbrush.md)
*   [Examples](./transformbrush.md)