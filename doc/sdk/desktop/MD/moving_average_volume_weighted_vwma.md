**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Volume Weighted (VWMA)](./moving_average_volume_weighted_vwma.md)

# Moving Average - Volume Weighted (VWMA)

# Moving Average \- Volume Weighted (VWMA)

## [Description](./moving_average_volume_weighted_vwma.md)

The Volume Weighted Moving Average is a weighted moving average that uses the volume as the weighting factor, so that higher volume days have more weight. It is a non\-cumulative moving average, in that only data within the time period is used in the calculation.

## [Syntax](./moving_average_volume_weighted_vwma.md)

`VWMA(int period)`

`VWMA(ISeries<double> input, int period)`

**Returns default value**

`VWMA(int period)[int barsAgo]`

`VWMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_volume_weighted_vwma.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_volume_weighted_vwma.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./moving_average_volume_weighted_vwma.md)

```csharp
// OnBarUpdate method
protected override void OnBarUpdate()
{
   // Evaluates for a VWMA cross over to the long side
   if (CrossAbove(VWMA(14), VWMA(40), 1))
       Print("We have a moving average cross over long");

   // Prints the current 14 period VWMA of high prices to the output window
   double value = VWMA(High, 14)[0];
   Print("The current VWMA value of high prices is " + value.ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_volume_weighted_vwma.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_volume_weighted_vwma.md)
*   [Syntax](./moving_average_volume_weighted_vwma.md)
*   [Return Value](./moving_average_volume_weighted_vwma.md)
*   [Parameters](./moving_average_volume_weighted_vwma.md)
*   [Examples](./moving_average_volume_weighted_vwma.md)
*   [Source Code](./moving_average_volume_weighted_vwma.md)