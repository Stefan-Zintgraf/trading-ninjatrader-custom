**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Adaptive Price Zone (APZ)](./adaptive_price_zone_apz.md)

# Adaptive Price Zone (APZ)

# Adaptive Price Zone (APZ)

## [Description](./adaptive_price_zone_apz.md)

The Adaptive Price Zone indicator from the S&C, September 2006 article "Trading With An Adpative Price Zone" by Lee Leibfarth is a set of bands based on a short term double smooth exponential moving average. The bands form a channel that surrounds the average price and tracks price fluctuations quickly, especially in volatile markets. As price crosses above the zone it can signal an opportunity to sell in anticipation of a reversal. As price crosses below the zone it can signal an opportunity to buy in anticipation of a reversal.

## [Syntax](./adaptive_price_zone_apz.md)

`APZ(double bandPct, int period)`

`APZ(ISeries<double> input, double bandPct, int period)`

**Returns upper band value**

`APZ(double bandPct, int period).Upper[int barsAgo]`

`APZ(ISeries<double> input, double bandPct, int period).Upper[int barsAgo]`

**Returns lower band value**

`APZ(double bandPct, int period).Lower[int barsAgo]`

`APZ(ISeries<double> input, double bandPct, int period).Lower[int barsAgo]`

## [Return Value](./adaptive_price_zone_apz.md)

**double;** Accessing this method via an index value \[int barsAgo\] returns the indicator value of the referenced bar.

## [Parameters](./adaptive_price_zone_apz.md)

Parameter

Description

bandPct

The number of standard deviations

input

Indicator source data

period

Number of bars used in the calculation

## [Example](./adaptive_price_zone_apz.md)

```csharp
// Prints the current upper band value of a 20 period APZ
double upperValue = APZ(2, 20).Upper[0];
Print("The current APZ upper value is " + upperValue.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./adaptive_price_zone_apz.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./adaptive_price_zone_apz.md)
*   [Syntax](./adaptive_price_zone_apz.md)
*   [Return Value](./adaptive_price_zone_apz.md)
*   [Parameters](./adaptive_price_zone_apz.md)
*   [Example](./adaptive_price_zone_apz.md)
*   [Source Code](./adaptive_price_zone_apz.md)