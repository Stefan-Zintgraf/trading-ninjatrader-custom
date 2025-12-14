**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Dynamic Momentum Index (DMIndex)](./dynamic_momentum_index_dmindex.md)

# Dynamic Momentum Index (DMIndex)

# Dynamic Momentum Index (DMIndex)

## [Description](./dynamic_momentum_index_dmindex.md)

An indicator used in technical analysis that determines overbought and oversold conditions of a particular asset. This indicator is very similar to the relative strength index (**RSI**). The main difference between the two is that the **RSI** uses a fixed number of time periods (usually 14), while the dynamic momentum index uses different time periods as volatility changes.

... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/dynamicmomentumindex.asp)

## [Syntax](./dynamic_momentum_index_dmindex.md)

`DMIndex(int smooth)`

`DMIndex(ISeries<double> input, int smooth)`

**Returns default value**

`DMIndex(int period)[barsAgo]`

`DMIndex(ISeries<double> input, int smooth)[int barsAgo]`

## [Return Value](./dynamic_momentum_index_dmindex.md)

**double**; Accessing this method via an index value \[**int barsAgo**\] returns the indicator value of the referenced bar.

## [Parameters](./dynamic_momentum_index_dmindex.md)

input

smooth

Indicator source data ([Series<`T`\>](./seriest.md))

The number of bars to include in the calculation

## [Examples](./dynamic_momentum_index_dmindex.md)

```csharp
// Prints the current value of DMIndex using default price type
double value = DMIndex(3)[0];
Print("The current DMIndex value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./dynamic_momentum_index_dmindex.md)

You can view this indicator method source code by selecting the menu New > **NinjaScript** Editor > Indicators within the **NinjaTrader** Control Center window.

#### ON THIS PAGE

*   [Description](./dynamic_momentum_index_dmindex.md)
*   [Syntax](./dynamic_momentum_index_dmindex.md)
*   [Return Value](./dynamic_momentum_index_dmindex.md)
*   [Parameters](./dynamic_momentum_index_dmindex.md)
*   [Examples](./dynamic_momentum_index_dmindex.md)
*   [Source Code](./dynamic_momentum_index_dmindex.md)