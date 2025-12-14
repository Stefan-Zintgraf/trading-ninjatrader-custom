**Path**: [ChartAnchor](./chartanchor.md) > [MoveAnchorX()](./moveanchorx.md)

# MoveAnchorX()

# MoveAnchorX()

## [Definition](./moveanchorx.md)

Moves an anchor's x value from start point by a delta point amount.

## [Method Return Value](./moveanchorx.md)

This method does not return a value.

## [Syntax](./moveanchorx.md)

`<chartanchor>.MoveAnchorX(Point startPoint, Point deltaPoint, ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale)`

## [Method Parameters](./moveanchorx.md)

**startPoint**

The chart anchor's original starting point value

**deltaPoint**

The chart anchor's new point value to be updated

**chartControl**

A ChartControl representing the x\-axis

**chartScale**

A ChartScale representing the y\-axis

## [Examples](./moveanchorx.md)

```csharp
//move only the chart anchors x (bar/time) value
MyAnchor.MoveAnchorX(lastPoint, newPoint, chartControl, chartScale);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./moveanchorx.md)
*   [Method Return Value](./moveanchorx.md)
*   [Syntax](./moveanchorx.md)
*   [Method Parameters](./moveanchorx.md)
*   [Examples](./moveanchorx.md)