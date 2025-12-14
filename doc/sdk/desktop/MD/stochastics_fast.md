**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Stochastics Fast](./stochastics_fast.md)

# Stochastics Fast

# Stochastics Fast

## [Description](./stochastics_fast.md)

Developed by George C. Lane in the late 1950s, the Stochastic Oscillator is a momentum indicator that shows the location of the current close relative to the high/low range over a set number of periods. Closing levels that are consistently near the top of the range indicate accumulation (buying pressure) and those near the bottom of the range indicate distribution (selling pressure).

... Courtesy of [StockCharts](https://chartschool.stockcharts.com/table-of-contents/technical-indicators-and-overlays/technical-indicators/stochastic-oscillator-fast-slow-and-full)

## [Syntax](./stochastics_fast.md)

`StochasticsFast(int periodD, int periodK)`

`StochasticsFast(ISeries<double> input, int periodD, int periodK)`

**Returns %D value**

`StochasticsFast(int periodD, int periodK).D[int barsAgo]`

`StochasticsFast(ISeries<double> input, int periodD, int periodK).D[int barsAgo]`

**Returns %K value**

`StochasticsFast(int periodD, int periodK).K[int barsAgo]`

`StochasticsFast(ISeries<double> input, int periodD, int periodK).K[int barsAgo]`

## [Return Value](./stochastics_fast.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./stochastics_fast.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

periodD

The period for the moving average of periodD

periodK

The period for the moving average of periodK

## [Examples](./stochastics_fast.md)

```csharp
// Prints the current %D value
double value = StochasticsFast(3, 14).D[0];
Print("The current StochasticsFast %D value is " + value.ToString());

// Prints the current %K value
double value = StochasticsFast(3, 14).K[0];
Print("The current StochasticsFast %K value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./stochastics_fast.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./stochastics_fast.md)
*   [Syntax](./stochastics_fast.md)
*   [Return Value](./stochastics_fast.md)
*   [Parameters](./stochastics_fast.md)
*   [Examples](./stochastics_fast.md)
*   [Source Code](./stochastics_fast.md)