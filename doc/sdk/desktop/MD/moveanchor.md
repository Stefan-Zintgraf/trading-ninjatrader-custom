**Path**: [ChartAnchor](./chartanchor.md) > [MoveAnchor()](./moveanchor.md)

# MoveAnchor()

# MoveAnchor()

## [Definition](./moveanchor.md)

Moves a Chart Anchor's x and y values from start point by a delta point amount.

## [Method Return Value](./moveanchor.md)

This method does not return a value.

## [Syntax](./moveanchor.md)

`<chartanchor>.MoveAnchor(ChartAnchor startDataPoint, ChartAnchor deltaDataPoint, ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, DrawingTool drawingTool)`

## [Method Parameters](./moveanchor.md)

**startPoint**

The chart anchor's original starting location value represented by a point structure

**startDataPoint**

A chart anchor's original starting location value represented by a chart anchor

**deltaPoint**

The chart anchor's new location value to be updated represented by a point structure

**deltaDataPoint**

The chart anchor's new location value to be updated represented by a chart anchor

**chartControl**

A ChartControl representing the x\-axis

**chartScale**

A ChartScale representing the y\-axis

**chartPanel**

A ChartPanel representing the panel for the chart

**drawingTool**

The drawing tool which owns the chart anchor to be moved (usually this).

## [Examples](./moveanchor.md)

```csharp
//move the chart anchors x and y values
MyAnchor.MoveAnchor(lastPoint, newPoint, chartControl, chartPanel, chartScale, this);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./moveanchor.md)
*   [Method Return Value](./moveanchor.md)
*   [Syntax](./moveanchor.md)
*   [Method Parameters](./moveanchor.md)
*   [Examples](./moveanchor.md)