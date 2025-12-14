**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Accumulation/Distribution (ADL)](./accumulation_distribution_adl.md)

# Accumulation/Distribution (ADL)

# Accumulation/Distribution (ADL)

## [Description](./accumulation_distribution_adl.md)

There are many indicators available to measure volume and the flow of money for a particular stock, index or security. One of the most popular volume indicators over the years has been the Accumulation/Distribution Line. The basic premise behind volume indicators, including the Accumulation/Distribution Line, is that volume precedes price. Volume reflects the amount of shares traded in a particular stock, and is a direct reflection of the money flowing into and out of a stock. Many times before a stock advances, there will be period of increased volume just prior to the move. Most volume or money flow indicators are designed to identify early increases in positive or negative volume flow to gain an edge before the price moves. (Note: the terms "money flow" and "volume flow" are essentially interchangeable.)

## [Syntax](./accumulation_distribution_adl.md)

`ADL()`

`ADL(ISeries<double> input)`

**Returns default value**

`ADL()[int barsAgo]`

`ADL(ISeries<double> input)[int barsAgo]`

## [Return Value](./accumulation_distribution_adl.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./accumulation_distribution_adl.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

## [Example](./accumulation_distribution_adl.md)

```csharp
// Evaluates if ADL is rising
bool isRising = IsRising(ADL());
Print("Is ADL rising? " + isRising);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./accumulation_distribution_adl.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./accumulation_distribution_adl.md)
*   [Syntax](./accumulation_distribution_adl.md)
*   [Return Value](./accumulation_distribution_adl.md)
*   [Parameters](./accumulation_distribution_adl.md)
*   [Example](./accumulation_distribution_adl.md)
*   [Source Code](./accumulation_distribution_adl.md)