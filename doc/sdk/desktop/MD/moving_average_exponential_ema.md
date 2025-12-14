**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Exponential (EMA)](./moving_average_exponential_ema.md)

# Moving Average - Exponential (EMA)

# Moving Average \- Exponential (EMA)

## [Description](./moving_average_exponential_ema.md)

The exponential moving average is but one type of a moving average. In a simple moving average, all price data has an equal weight in the computation of the average with the oldest value removed as each new value is added. In the exponential moving average equation the most recent market action is assigned greater importance as the average is calculated. The oldest pricing data in the exponential moving average is however never removed.

## [Syntax](./moving_average_exponential_ema.md)

`EMA(int period)`

`EMA(ISeries<double> input, int period)`

**Returns default value**

`EMA(int period)[int barsAgo]`

`EMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_exponential_ema.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_exponential_ema.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./moving_average_exponential_ema.md)

```csharp
// Prints the current value of a 20 period EMA using default price type
double value = EMA(20)[0];
Print("The current EMA value is " + value.ToString());
  
// Prints the current value of a 20 period EMA using high price type
double value = EMA(High, 20)[0];
Print("The current EMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_exponential_ema.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_exponential_ema.md)
*   [Syntax](./moving_average_exponential_ema.md)
*   [Return Value](./moving_average_exponential_ema.md)
*   [Parameters](./moving_average_exponential_ema.md)
*   [Examples](./moving_average_exponential_ema.md)
*   [Source Code](./moving_average_exponential_ema.md)