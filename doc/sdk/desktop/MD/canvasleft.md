**Path**: [ChartControl](./chartcontrol.md) > [CanvasLeft](./canvasleft.md)

# CanvasLeft

# CanvasLeft

## [Definition](./canvasleft.md)

Indicates the x\-coordinate (in pixels) of the beginning of the chart canvas area.

## [Property Value](./canvasleft.md)

A **double** representing the beginning of the chart canvas area.

## [Syntax](./canvasleft.md)

`<chartcontrol>.CanvasLeft`

## [Examples](./canvasleft.md)

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

Based on the image below, CanvasLeft reveals that the chart canvas area begins at x\-coordinate 53.

![ChartControl_CanvasLeft](https://cdn.sanity.io/images/1hlwceal/production/15a88a12f954be17f806e77636bf43698cf46e3f-575x550.png)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When no data series are left\-aligned on a chart, CanvasLeft will return 0, representing the x\-coordinate origin, because the chart canvas will begin at coordinate 0.

#### ON THIS PAGE

*   [Definition](./canvasleft.md)
*   [Property Value](./canvasleft.md)
*   [Syntax](./canvasleft.md)
*   [Examples](./canvasleft.md)