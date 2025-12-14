**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Stochastics RSI (StochRSI)](./stochastics_rsi_stochrsi.md)

# Stochastics RSI (StochRSI)

# Stochastics RSI (StochRSI)

## [Description](./stochastics_rsi_stochrsi.md)

This is an indicator on indicator implementation. It is simply a **[Stochastics](./stochastics.md)** indicator applied on **[RSI](./relative_strength_index_rsi.md)**.

## [Syntax](./stochastics_rsi_stochrsi.md)

`StochRSI(int period)`

`StochRSI(ISeries<double> input, int period)`

**Returns default value**

`StochRSI(int period)[int barsAgo]`

`StochRSI[ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./stochastics_rsi_stochrsi.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./stochastics_rsi_stochrsi.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./stochastics_rsi_stochrsi.md)

```csharp
// Evaluates if the current bar StochRSI value is greater than the value one bar ago
if (StochRSI(14)[0] > StochRSI(14)[1])
   Print("Stochastics RSI is rising");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./stochastics_rsi_stochrsi.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./stochastics_rsi_stochrsi.md)
*   [Syntax](./stochastics_rsi_stochrsi.md)
*   [Return Value](./stochastics_rsi_stochrsi.md)
*   [Parameters](./stochastics_rsi_stochrsi.md)
*   [Examples](./stochastics_rsi_stochrsi.md)
*   [Source Code](./stochastics_rsi_stochrsi.md)