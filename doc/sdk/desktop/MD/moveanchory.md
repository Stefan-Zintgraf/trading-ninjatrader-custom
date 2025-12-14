**Path**: [ChartAnchor](./chartanchor.md) > [MoveAnchorY()](./moveanchory.md)

# MoveAnchorY()

# MoveAnchorY()

## [Definition](./moveanchory.md)

Moves an anchor's y value from start point by a delta point amount.

## [Method Return Value](./moveanchory.md)

This method does not return a value.

## [Syntax](./moveanchory.md)

`<chartanchor>.MoveAnchorY(Point startPoint, Point deltaPoint, ChartControl chartControl, ChartScale chartScale)`

## [Method Parameters](./moveanchory.md)

**startPoint**

The chart anchor's original starting point value

**deltaPoint**

The chart anchor's new point value to be updated

**chartControl**

A ChartControl representing the x\-axis

**chartScale**

A ChartScale representing the y\-axis

## [Examples](./moveanchory.md)

```csharp
//move only the chart anchors Y (price) value
MyAnchor.MoveAnchorY(lastPoint, newPoint, chartControl, chartPanel, chartScale);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./moveanchory.md)
*   [Method Return Value](./moveanchory.md)
*   [Syntax](./moveanchory.md)
*   [Method Parameters](./moveanchory.md)
*   [Examples](./moveanchory.md)