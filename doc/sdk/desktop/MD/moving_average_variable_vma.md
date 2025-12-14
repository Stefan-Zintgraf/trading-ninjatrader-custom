**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Variable (VMA)](./moving_average_variable_vma.md)

# Moving Average - Variable (VMA)

# Moving Average \- Variable (VMA)

## [Description](./moving_average_variable_vma.md)

A Variable Moving Average is an exponential moving average that automatically adjusts its smoothing percentage based on market volatility. Giving more weight to the current data increases sensitivity thus making it a better signal indicator for short and long term markets.

## [Syntax](./moving_average_variable_vma.md)

`VMA(int period, int volatilityPeriod)`

`VMA(ISeries<double> input, int period, int volatilityPeriod)`

**Returns default value**

`VMA(int period, int volatilityPeriod)[int barsAgo]`

`VMA(ISeries<double> input, int period, int volatilityPeriod)[int barsAgo]`

## [Return Value](./moving_average_variable_vma.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_variable_vma.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

volatilityPeriod

The number of bars used to calculate the [CMO](./chande_momentum_oscillator_cmo.md) based volatility index

## [Examples](./moving_average_variable_vma.md)

```csharp
// OnBarUpdate method of a strategy
protected override void OnBarUpdate()
{
   // Print out the VMA value of lows 3 bars ago for fun
   double value = VMA(Low, 9, 9)[3];
   Print("The value is " + value.ToString());
 
   // Go long if price closes above the current VMA value
   if (Close[0] > VMA(9, 9)[0])
       EnterLong();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_variable_vma.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_variable_vma.md)
*   [Syntax](./moving_average_variable_vma.md)
*   [Return Value](./moving_average_variable_vma.md)
*   [Parameters](./moving_average_variable_vma.md)
*   [Examples](./moving_average_variable_vma.md)
*   [Source Code](./moving_average_variable_vma.md)