**Path**: [ChartControl](./chartcontrol.md) > [CanvasRight](./canvasright.md)

# CanvasRight

# CanvasRight

## [Definition](./canvasright.md)

Indicates the x\-coordinate (in pixels) of the end of the chart canvas area.

## [Property Value](./canvasright.md)

A double representing the end of the chart canvas area.

## [Syntax](./canvasright.md)

`<chartcontrol>.CanvasRight`

## [Examples](./canvasright.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Store the beginning and ending x-coordinates of the canvas area
   double canvasBeginCoordinate = chartControl.CanvasLeft;
   double canvasEndCoordinate = chartControl.CanvasRight;
 
   // Print the stored values
   Print(String.Format("Chart canvas begins at x-coordinate {0} and ends at x-coordinate {1}", canvasBeginCoordinate, canvasEndCoordinate)); 
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, CanvasRight reveals that the chart canvas ends at x\-coordinate 526.

![ChartControl_CanvasRight](https://cdn.sanity.io/images/1hlwceal/production/80d6c71d835ef48a469bfe4be0a1789ba49dd01d-575x550.png)

#### ON THIS PAGE

*   [Definition](./canvasright.md)
*   [Property Value](./canvasright.md)
*   [Syntax](./canvasright.md)
*   [Examples](./canvasright.md)