**Path**: [System Indicator Methods](./system_indicator_methods.md) > [True Strength Index (TSI)](./true_strength_index_tsi.md)

# True Strength Index (TSI)

# True Strength Index (TSI)

## [Description](./true_strength_index_tsi.md)

The True Strength Index (TSI) is a momentum\-based indicator, developed by William Blau. Designed to determine both trend and overbought/oversold conditions, the TSI is applicable to intraday time frames as well as long term trading.

## [Syntax](./true_strength_index_tsi.md)

`TSI(int fast, int slow)`

`TSI(ISeries<`double`> input, int fast, int slow)`

**Returns default value**

`TSI(int fast, int slow)[int barsAgo]`

`TSI(ISeries<`double`> input, int fast, int slow)[int barsAgo]`

## [Return Value](./true_strength_index_tsi.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./true_strength_index_tsi.md)

Parameter

Description

fast

Period of the fast smoothing factor

input

Indicator source data ([Series<`T`\>](./seriest.md))

slow

Period of the slow smoothing factor

## [Examples](./true_strength_index_tsi.md)

```csharp
// Prints the current value of a 20 period TSI using default price type  
double value = TSI(20, 10)[0];  
Print("The current TSI value is " + value.ToString());  
   
// Prints the current value of a 20 period TSI using high price type  
double value = TSI(High, 20, 10)[0];  
Print("The current TSI value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./true_strength_index_tsi.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./true_strength_index_tsi.md)
*   [Syntax](./true_strength_index_tsi.md)
*   [Return Value](./true_strength_index_tsi.md)
*   [Parameters](./true_strength_index_tsi.md)
*   [Examples](./true_strength_index_tsi.md)
*   [Source Code](./true_strength_index_tsi.md)