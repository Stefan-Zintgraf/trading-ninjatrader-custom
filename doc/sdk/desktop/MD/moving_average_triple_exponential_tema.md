**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Triple Exponential (TEMA)](./moving_average_triple_exponential_tema.md)

# Moving Average - Triple Exponential (TEMA)

# Moving Average \- Triple Exponential (TEMA)

## [Description](./moving_average_triple_exponential_tema.md)

The TEMA is a smoothing indicator. It was developed by Patrick Mulloy and is described in his article in the January, 1994 issue of Technical Analysis of Stocks and Commodities magazine.

## [Syntax](./moving_average_triple_exponential_tema.md)

`TEMA(int period)`

`TEMA(ISeries<double> input, int period)`

**Returns default value**

`TEMA(int period)[int barsAgo]`

`TEMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_triple_exponential_tema.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_triple_exponential_tema.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./moving_average_triple_exponential_tema.md)

```csharp
// Prints the current value of a 20 period TEMA using default price type
double value = TEMA(20)[0];
Print("The current TEMA value is " + value.ToString());

// Prints the current value of a 20 period TEMA using high price type
double value = TEMA(High, 20)[0];
Print("The current TEMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_triple_exponential_tema.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_triple_exponential_tema.md)
*   [Syntax](./moving_average_triple_exponential_tema.md)
*   [Return Value](./moving_average_triple_exponential_tema.md)
*   [Parameters](./moving_average_triple_exponential_tema.md)
*   [Examples](./moving_average_triple_exponential_tema.md)
*   [Source Code](./moving_average_triple_exponential_tema.md)