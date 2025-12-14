**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Relative Spread Strength (RSS)](./relative_spread_strength_rss.md)

# Relative Spread Strength (RSS)

# Relative Spread Strength (RSS)

## [Description](./relative_spread_strength_rss.md)

Developed by Ian Copsey, **Relative Spread Strength** is a variation to the [Relative Strength Index](./relative_strength_index_rsi.md).

## [Syntax](./relative_spread_strength_rss.md)

`RSS(int eMA1, int eMA2, int length)`

`RSS(ISeries<double> input, int eMA1, int eMA2, int length)`

**Returns default value**

`RSS(int eMA1, int eMA2, int length)[int barsAgo]`

`RSS(ISeries<double> input, int eMA1, int eMA2, int length)[int barsAgo]`

## [Return Value](./relative_spread_strength_rss.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./relative_spread_strength_rss.md)

Parameter

Description

eMA1

First EMA's period

eMA2

Second EMA's period

input

Indicator source data ([Series<`T`\>](./seriest.md))

length

Number of bars used in the calculation

## [Examples](./relative_spread_strength_rss.md)

```csharp
// Prints the current value of the RSS using default price type
double value = RSS(10, 40, 5)[0];
Print("The current RSS value is " + value.ToString());

// Prints the current value of the RSS using high price type
double value = RSS(High, 10, 40, 5)[0];
Print("The current RSS value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./relative_spread_strength_rss.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./relative_spread_strength_rss.md)
*   [Syntax](./relative_spread_strength_rss.md)
*   [Return Value](./relative_spread_strength_rss.md)
*   [Parameters](./relative_spread_strength_rss.md)
*   [Examples](./relative_spread_strength_rss.md)
*   [Source Code](./relative_spread_strength_rss.md)