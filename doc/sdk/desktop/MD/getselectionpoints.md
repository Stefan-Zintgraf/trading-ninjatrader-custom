**Path**: [ChartAnchor](./chartanchor.md) > [GetSelectionPoints()](./getselectionpoints.md)

# GetSelectionPoints()

# GetSelectionPoints()

## [Definition](./getselectionpoints.md)

Returns the chart object's data points where the user can interact. These points are used to visually indicate that the chart object is selected and allow the user to manipulate the chart object. This method is only called when **IsSelected** is set to true.

## [Method Return Value](./getselectionpoints.md)

A collection of [Points](./points.md) representing the x\- and y\-coordinates of the chart object.

## [Syntax](./getselectionpoints.md)

You must override the method using the following syntax:

`public override Point[] GetSelectionPoints(ChartControl chartControl, ChartScale chartScale){ }`

## [Method Parameters](./getselectionpoints.md)

**chartControl**

A [ChartControl](./chartcontrol.md) representing the x\-axis

**chartScale**

A [ChartScale](./chartscale.md) representing the y\-axis

## [Examples](./getselectionpoints.md)

```csharp
public override Point[] GetSelectionPoints(ChartControl chartControl, ChartScale chartScale)
{        
    ChartPanel chartPanel = chartControl.ChartPanels[chartScale.PanelIndex];
    // get the anchor point to be displayed on the drawing tool
    Point anchorPoint = Anchor.GetPoint(chartControl, chartPanel, chartScale, false);
    return new[] { anchorPoint };
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getselectionpoints.md)
*   [Method Return Value](./getselectionpoints.md)
*   [Syntax](./getselectionpoints.md)
*   [Method Parameters](./getselectionpoints.md)
*   [Examples](./getselectionpoints.md)