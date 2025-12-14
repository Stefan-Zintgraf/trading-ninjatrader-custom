**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Weighted (WMA)](./moving_average_weighted_wma.md)

# Moving Average - Weighted (WMA)

# Moving Average \- Weighted (WMA)

## [Description](./moving_average_weighted_wma.md)

The Weighted Moving Average gives the latest price more weight than prior prices. Each prior price in the period gets progressively less weight as they become older.

## [Syntax](./moving_average_weighted_wma.md)

`WMA(int period)`

`WMA(ISeries<double> input, int period)`

**Returns default value**

`WMA(int period)[int barsAgo]`

`WMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_weighted_wma.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_weighted_wma.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./moving_average_weighted_wma.md)

```csharp
// Prints the current value of a 20 period WMA using default price type
double value = WMA(20)[0];
Print("The current WMA value is " + value.ToString());

// Prints the current value of a 20 period WMA using high price type
double value = WMA(High, 20)[0];
Print("The current WMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_weighted_wma.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_weighted_wma.md)
*   [Syntax](./moving_average_weighted_wma.md)
*   [Return Value](./moving_average_weighted_wma.md)
*   [Parameters](./moving_average_weighted_wma.md)
*   [Examples](./moving_average_weighted_wma.md)
*   [Source Code](./moving_average_weighted_wma.md)