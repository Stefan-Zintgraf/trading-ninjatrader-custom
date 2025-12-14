**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Average True Range (ATR)](./average_true_range_atr.md)

# Average True Range (ATR)

# Average True Range (ATR)

## [Description](./average_true_range_atr.md)

A measure of volatility introduced by Welles Wilder in his book: New Concepts in Technical Trading Systems.

The True Range indicator is the greatest of the following:

*   current high less the current low.
*   the absolute value of the current high less the previous close.
*   the absolute value of the current low less the previous close.

The Average True Range is a moving average (generally 14\-days) of the True Ranges.

... Courtesy of [Investopedia](http://www.investopedia.com/terms/a/atr.asp)

The original Wilder formula for an exponential moving average with a smoothing constant (k = 1/ Period) is used to calculate the ATR.

## [Syntax](./average_true_range_atr.md)

`ATR(int period)`

`ATR(ISeries<`double> `input, int period)`

**Returns default value**

`ATR(int period)[int barsAgo]`

`ATR(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./average_true_range_atr.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./average_true_range_atr.md)

Parameter

Description

input

Indicator source data

period

Number of bars used in the calculation

## [Example](./average_true_range_atr.md)

```csharp
// Prints the current value of a 20 period ATR using default price type
double value = ATR(20)[0];
Print("The current ATR value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./average_true_range_atr.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./average_true_range_atr.md)
*   [Syntax](./average_true_range_atr.md)
*   [Return Value](./average_true_range_atr.md)
*   [Parameters](./average_true_range_atr.md)
*   [Example](./average_true_range_atr.md)
*   [Source Code](./average_true_range_atr.md)