**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Kaufman's Adaptive (KAMA)](./moving_average_kaufmans_adaptive.md)

# Moving Average - Kaufman's Adaptive (KAMA)

# Moving Average \- Kaufman's Adaptive (KAMA)

## [Description](./moving_average_kaufmans_adaptive.md)

Developed by Perry Kaufman, this indicator is an EMA using an Efficiency Ratio to modify the smoothing constant, which ranges from a minimum of Fast Length to a maximum of Slow Length.

## [Syntax](./moving_average_kaufmans_adaptive.md)

`KAMA(int fast, int period, int slow)`

`KAMA(ISeries<double> input, int fast, int period, int slow)`

**Returns default value**

`KAMA(int fast, int period, int slow)[int barsAgo]`

`KAMA(ISeries<double> input, int fast, int period, int slow)[int barsAgo]`

## [Return Value](./moving_average_kaufmans_adaptive.md)

**double;** Accessing this method via an index value \[int barsAgo\] returns the indicator value of the referenced bar.

## [Parameters](./moving_average_kaufmans_adaptive.md)

**fast**

Fast length

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

**slow**

Slow length

## [Examples](./moving_average_kaufmans_adaptive.md)

```csharp
// Prints the current value of a 20 period KAMA using default price type
double value = KAMA(2, 20, 30)[0];
Print("The current KAMA value is " + value.ToString());

// Prints the current value of a 20 period KAMA using high price type
double value = KAMA(High, 2, 20, 30)[0];
Print("The current KAMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_kaufmans_adaptive.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_kaufmans_adaptive.md)
*   [Syntax](./moving_average_kaufmans_adaptive.md)
*   [Return Value](./moving_average_kaufmans_adaptive.md)
*   [Parameters](./moving_average_kaufmans_adaptive.md)
*   [Examples](./moving_average_kaufmans_adaptive.md)
*   [Source Code](./moving_average_kaufmans_adaptive.md)