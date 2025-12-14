**Path**: [System Indicator Methods](./system_indicator_methods.md) > [CandleStickPattern](./candlestickpattern.md)

# CandleStickPattern

# CandleStickPattern

## [Description](./candlestickpattern.md)

Detects the specified candle stick pattern.

## [Syntax](./candlestickpattern.md)

`CandleStickPattern(ChartPattern pattern, int trendStrength)`

`CandleStickPattern(ISeries<double> input, ChartPattern pattern, int trendStrength)`

**Returns a value indicating if the specified pattern was detected**

`CandleStickPattern(ChartPattern pattern, int trendStrength)[int barsAgo]`

`CandleStickPattern(ISeries<double> input, ChartPattern pattern, int trendStrength)[int barsAgo]`

## [Return Value](./candlestickpattern.md)

A **double** value representing pattern found. Returns a value of 1 if the pattern is found; returns a value of 0 if no pattern was found.

Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./candlestickpattern.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

pattern

Possible values are:

*   **ChartPattern.BearishBeltHold**
*   **ChartPattern.BearishEngulfing**
*   **ChartPattern.BearishHarami**
*   **ChartPattern.BearishHaramiCross**
*   **ChartPattern.BullishBeltHold**
*   **ChartPattern.BullishEngulfing**
*   **ChartPattern.BullishHarami**
*   **ChartPattern.BullishHaramiCross**
*   **ChartPattern.DarkCloudCover**
*   **ChartPattern.Doji**
*   **ChartPattern.DownsideTasukiGap**
*   **ChartPattern.EveningStar**
*   **ChartPattern.FallingThreeMethods**
*   **ChartPattern.Hammer**
*   **ChartPattern.HangingMan**
*   **ChartPattern.InvertedHammer**
*   **ChartPattern.MorningStart**
*   **ChartPattern.PiercingLine**
*   **ChartPattern.RisingThreeMethods**
*   **ChartPattern.ShootingStar**
*   **ChartPattern.StickSandwich**
*   **ChartPattern.ThreeBlackCrows**
*   **ChartPattern.ThreeWhiteSoldiers**
*   **ChartPattern.UpsideGapTwoCrows**
*   **ChartPattern.UpsideTasukiGap**

trendStrength

The number of required bars to the left and right of the swing point used to determine trend. A value of zero will exclude the requirement of a trend and only detect based on the candles themselves.

## [Examples](./candlestickpattern.md)

```csharp
// Go long if the current bar is a bullish engulfing pattern
if (CandleStickPattern(ChartPattern.BullishEngulfing, 4)[0] == 1)
    EnterLong();

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./candlestickpattern.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./candlestickpattern.md)
*   [Syntax](./candlestickpattern.md)
*   [Return Value](./candlestickpattern.md)
*   [Parameters](./candlestickpattern.md)
*   [Examples](./candlestickpattern.md)
*   [Source Code](./candlestickpattern.md)