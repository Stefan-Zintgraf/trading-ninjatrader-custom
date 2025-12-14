**Path**: [ChartAnchor](./chartanchor.md) > [GetPoint()](./getpoint.md)

# GetPoint()

# GetPoint()

## [Definition](./getpoint.md)

Returns a chart anchor's data point in device pixels

## [Method Return Value](./getpoint.md)

A **Point** structure; a point value in device pixels for a chart's given panel & scale

## [Syntax](./getpoint.md)

`<chartanchor>.GetPoint(ChartControl chartControl, ChartPanel chartPanel, ChartScale, bool pixelAlign)`

## [Method Parameters](./getpoint.md)

**chartControl**

A [ChartControl](./chartcontrol.md) representing the x\-axis

**chartPanel**

A [ChartPanel](./chartpanel.md) representing a panel of the chart

**chartScale**

A [ChartScale](./chartscale.md) representing the y\-axis

**pixelAlign**

An optional bool determining if the data point should be rounded to the closest .5 pixel point

## [Examples](./getpoint.md)

```csharp
//gets the chart anchor's data points
Point anchorPoint = MyAnchor.GetPoint(chartControl, chartPanel, chartScale);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getpoint.md)
*   [Method Return Value](./getpoint.md)
*   [Syntax](./getpoint.md)
*   [Method Parameters](./getpoint.md)
*   [Examples](./getpoint.md)