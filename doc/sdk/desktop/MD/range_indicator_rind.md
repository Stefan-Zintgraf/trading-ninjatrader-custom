**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Range Indicator (RIND)](./range_indicator_rind.md)

# Range Indicator (RIND)

# Range Indicator (RIND)

## [Description](./range_indicator_rind.md)

The Range indicator compares the intraday range (high \- low) to the inter\-day (close \- previous close) range. When the inter\-day range is less than the intraday range, the Range Indicator will be a high value. This signals an end to the current trend. When the Range Indicator is at a low level, a new trend is about to start.

The Range Indicator was developed by Jack Weinberg and was introduced in his article in the June, 1995 issue of Technical Analysis of Stocks & Commodities magazine.

## [Syntax](./range_indicator_rind.md)

`RIND(int periodQ, int smooth)`

`RIND(ISeries<double>`` input, int periodQ, int smooth)`

\*\*Returns default value \*\*

`RIND(int periodQ, int smooth)[int barsAgo]`

`RIND(ISeries<double> input, int periodQ, int smooth)[int barsAgo]`

## [Return Value](./range_indicator_rind.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./range_indicator_rind.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

periodQ

The number of bars to include in the calculation for the short term stochastic range lookback

smooth

The number of bars to include for the EMA smoothing of the indicator

## [Examples](./range_indicator_rind.md)

```csharp
// Prints out a historical RIND value
double value = RIND(3, 10)[5];
Print("RIND value of 5 bars ago is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./range_indicator_rind.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./range_indicator_rind.md)
*   [Syntax](./range_indicator_rind.md)
*   [Return Value](./range_indicator_rind.md)
*   [Parameters](./range_indicator_rind.md)
*   [Examples](./range_indicator_rind.md)
*   [Source Code](./range_indicator_rind.md)