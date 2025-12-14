**Path**: [ChartAnchor](./chartanchor.md) > [CopyDataValues()](./copydatavalues.md)

# CopyDataValues()

# CopyDataValues()

## [Definition](./copydatavalues.md)

Copies the **ChartAnchor** time and price values from one anchor to another. This includes the **BarsAgo**, **SlotIndex**, **Time**, **Price**, and **DrawnOnBar** values. This method is useful for updating a chart anchor to a recent data point when the user interacts with the drawing chart anchor.

## [Method Return Value](./copydatavalues.md)

This method does not return a value.

## [Syntax](./copydatavalues.md)

`<chartanchor>.CopyDataValues(ChartAnchor toAnchor)`

## [Method Parameters](./copydatavalues.md)

toAnchor

The ChartAnchor to copy

## [Examples](./copydatavalues.md)

```csharp

public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
   // if the user is moving the draw object, copy the most recent dataPoint to MyAnchor
   if (DrawingState == DrawingState.Moving)
     dataPoint.CopyDataValues(Anchor);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./copydatavalues.md)
*   [Method Return Value](./copydatavalues.md)
*   [Syntax](./copydatavalues.md)
*   [Method Parameters](./copydatavalues.md)
*   [Examples](./copydatavalues.md)