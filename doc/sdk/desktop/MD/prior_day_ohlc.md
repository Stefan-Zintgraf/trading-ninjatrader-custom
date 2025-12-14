**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Prior Day OHLC](./prior_day_ohlc.md)

# Prior Day OHLC

# Prior Day OHLC

## [Description](./prior_day_ohlc.md)

The prior day (session) open, high, low and close values.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Only use this indicator on intraday series.

## [Syntax](./prior_day_ohlc.md)

`PriorDayOHLC()`

`PriorDayOHLC(ISeries<double> input)`

**Returns prior session open value**

`PriorDayOHLC().PriorOpen[int barsAgo]`

`PriorDayOHLC(ISeries<double> input).PriorOpen[int barsAgo]`

**Returns prior session high value**

PriorDayOHLC().PriorHigh\[int barsAgo\]

`PriorDayOHLC(ISeries<double> input).PriorHigh[int barsAgo]`

**Returns prior session low value**

`PriorDayOHLC().PriorLow[int barsAgo]`

`PriorDayOHLC(ISeries<double> input).PriorLow[int barsAgo]`

**Returns prior session close value**

`PriorDayOHLC().PriorClose[int barsAgo]`

`PriorDayOHLC(ISeries<double> input).PriorClose[int barsAgo]`

## [Return Value](./prior_day_ohlc.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./prior_day_ohlc.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

## [Examples](./prior_day_ohlc.md)

```csharp
// Prints the value of the prior session low
double value = PriorDayOHLC().PriorLow[0];
Print("The prior session low value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./prior_day_ohlc.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./prior_day_ohlc.md)
*   [Syntax](./prior_day_ohlc.md)
*   [Return Value](./prior_day_ohlc.md)
*   [Parameters](./prior_day_ohlc.md)
*   [Examples](./prior_day_ohlc.md)
*   [Source Code](./prior_day_ohlc.md)