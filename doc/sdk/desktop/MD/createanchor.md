**Path**: [ChartAnchor](./chartanchor.md) > [CreateAnchor()](./createanchor.md)

# CreateAnchor()

# CreateAnchor()

## [Definition](./createanchor.md)

Used to create a new chart anchor at a specified mouse point.

## [Method Return Value](./createanchor.md)

A new **ChartAnchor** at a specified point in device pixels.

## [Syntax](./createanchor.md)

`CreateAnchor(Point point, ChartControl chartControl, ChartScale chartScale)`

## [Method Parameters](./createanchor.md)

**point**

A Point in device pixels representing the current mouse cursor position

**chartControl**

A ChartControl representing the x\-axis

**chartScale**

A ChartScale representing the y\-axis

## [Examples](./createanchor.md)

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)**
{
   // get the point where the mouse was clicked
   Point myPoint = dataPoint.GetPoint(chartControl, chartPanel, chartScale);

   // create an anchor at that point
   ChartAnchor MyAnchor = CreateAnchor(myPoint, chartControl, chartScale);

   Print(MyAnchor.Time); // 3/16/2015 8:18:48 AM
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./createanchor.md)
*   [Method Return Value](./createanchor.md)
*   [Syntax](./createanchor.md)
*   [Method Parameters](./createanchor.md)
*   [Examples](./createanchor.md)