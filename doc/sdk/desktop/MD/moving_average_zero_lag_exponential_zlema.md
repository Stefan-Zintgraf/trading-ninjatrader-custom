**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Zero Lag Exponential (ZLEMA)](./moving_average_zero_lag_exponential_zlema.md)

# Moving Average - Zero Lag Exponential (ZLEMA)

# Moving Average \- Zero Lag Exponential (ZLEMA)

## [Description](./moving_average_zero_lag_exponential_zlema.md)

The Zero\-Lag Exponential Moving Average is a variation on the Exponential Moving Average. The Zero\-Lag keeps the benefit of the heavier weighting of recent values, but attempts to remove lag by subtracting older data to minimize the cumulative effect.

... Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=ZeroLagExpMA.htm)

## [Syntax](./moving_average_zero_lag_exponential_zlema.md)

`ZLEMA(int period)`

`ZLEMA(ISeries<double> input, int period)`

**Returns default value**

`ZLEMA(int period)[int barsAgo]`

`ZLEMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_zero_lag_exponential_zlema.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_zero_lag_exponential_zlema.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./moving_average_zero_lag_exponential_zlema.md)

```csharp
// Prints the current value of a 20 period ZLEMA using default price type
double value = ZLEMA(20)[0];
Print("The current SMA value is " + value.ToString());

// Prints the current value of a 20 period ZLEMA using high price type
double value = ZLEMA(High, 20)[0];
Print("The current ZLEMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_zero_lag_exponential_zlema.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_zero_lag_exponential_zlema.md)
*   [Syntax](./moving_average_zero_lag_exponential_zlema.md)
*   [Return Value](./moving_average_zero_lag_exponential_zlema.md)
*   [Parameters](./moving_average_zero_lag_exponential_zlema.md)
*   [Examples](./moving_average_zero_lag_exponential_zlema.md)
*   [Source Code](./moving_average_zero_lag_exponential_zlema.md)