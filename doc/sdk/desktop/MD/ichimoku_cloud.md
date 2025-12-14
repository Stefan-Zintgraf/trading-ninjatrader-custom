**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Ichimoku Cloud](./ichimoku_cloud.md)

# Ichimoku Cloud

# Ichimoku Cloud

## [Description](./ichimoku_cloud.md)

The Ichimoku Cloud is a charting tool that shows potential support and resistance areas, trend direction, and momentum using a set of moving average\-based lines and a shaded area called the ‘cloud’. It helps users observe how price interacts with these components over time.

## [Syntax](./ichimoku_cloud.md)

`IchimokuCloud(int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement)`

`IchimokuCloud(ISeries<double> input, int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement)`

**Returns the Conversion value**

`IchimokuCloud(int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[0][int barsAgo]`

`IchimokuCloud(ISeries<double> input, int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[0][int barsAgo]`

**Returns the Base value**

`IchimokuCloud(int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[1][int barsAgo]`

`IchimokuCloud(ISeries<double> input, int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[1][int barsAgo]`

**Returns the LeadingSpanA value**

`IchimokuCloud(int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[2][int barsAgo]`

`IchimokuCloud(ISeries<double> input, int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[2][int barsAgo]`

**Returns the LeadingSpanB value**

`IchimokuCloud(int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[3][int barsAgo]`

`IchimokuCloud(ISeries<double> input, int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[3][int barsAgo]`

**Returns the Lagging value**

`IchimokuCloud(int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[4][int barsAgo]`

`IchimokuCloud(ISeries<double> input, int conversionPeriod, int basePeriod, int leadingSpanBPeriod, int spanDisplacement, int laggingDisplacement).Values[4][int barsAgo]`

## [Return Value](./ichimoku_cloud.md)

**double**; Accessing this method via an index value \[int barsAgo\] returns the indicator value of the referenced bar.

## [Parameters](./ichimoku_cloud.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

conversionPeriod

Conversion (Tenkan) period

basePeriod

Base (Kijun) period

leadingSpanBPeriod

Leading (Senkou) span B period

spanDisplacement

Span displacement

laggingDisplacement

Lagging (Chikou) displacement

## [Examples](./ichimoku_cloud.md)

```csharp
// Prints the current LeadingSpanA value
double leadingSpanAValue = IchimokuCloud(9, 26, 52, -26, 26).Values[2][0];
Print("The current Ichimoku LeadingSpanA value is " + leadingSpanAValue.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./ichimoku_cloud.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./ichimoku_cloud.md)
*   [Syntax](./ichimoku_cloud.md)
*   [Return Value](./ichimoku_cloud.md)
*   [Parameters](./ichimoku_cloud.md)
*   [Examples](./ichimoku_cloud.md)
*   [Source Code](./ichimoku_cloud.md)