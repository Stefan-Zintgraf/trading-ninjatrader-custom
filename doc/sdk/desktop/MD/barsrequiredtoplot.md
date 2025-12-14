**Path**: [AddPlot()](./addplot.md) > [BarsRequiredToPlot](./barsrequiredtoplot.md)

# BarsRequiredToPlot

# BarsRequiredToPlot

## [Definition](./barsrequiredtoplot.md)

The number of bars on a chart required before the script plots. By default, the value is 20 bars.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property is NOT the same as a minimum number of bars required to calculate the script values. OnBarUpdate will always start calculating for the first bar on the chart (CurrentBar 0)

## [Property Value](./barsrequiredtoplot.md)

An **int** value that represents the minimum number of bars required.

## [Syntax](./barsrequiredtoplot.md)

`BarsRequiredToPlot`

## [Examples](./barsrequiredtoplot.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
          BarsRequiredToPlot = 10; // Do not plot until the 11th bar on the chart
          AddPlot(Brushes.Orange, "SMA");
     }     
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barsrequiredtoplot.md)
*   [Property Value](./barsrequiredtoplot.md)
*   [Syntax](./barsrequiredtoplot.md)
*   [Examples](./barsrequiredtoplot.md)