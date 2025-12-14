**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Price Oscillator](./price_oscillator.md)

# Price Oscillator

# Price Oscillator

## [Description](./price_oscillator.md)

The Price Oscillator is an indicator based on the difference between two **moving averages**, and is expressed as either a percentage or in absolute terms.

... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_priceOscillator.html)

## [Syntax](./price_oscillator.md)

`PriceOscillator(int fast, int slow, int smooth)`

`PriceOscillator(ISeries<double> input, int fast, int slow, int smooth)`

**Returns default value**

`PriceOscillator(int fast, int slow, int smooth)[int barsAgo]`

`PriceOscillator(ISeries<double> input, int fast, int slow, int smooth)[int barsAgo]`

## [Return Value](./price_oscillator.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./price_oscillator.md)

Parameter

Description

fast

The number of bars to calculate the fast **EMA**

input

Indicator source data ([Series<`T`\>](./seriest.md))

slow

The number of bars to calculate the slow **EMA**

smooth

The number of bars to calculate the **EMA** signal line

## [Examples](./price_oscillator.md)

```csharp
// Prints the current value of a 20 period PriceOscillator using default price type
double value = PriceOscillator(12, 26, 9)[0];
Print("The current PriceOscillator value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./price_oscillator.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./price_oscillator.md)
*   [Syntax](./price_oscillator.md)
*   [Return Value](./price_oscillator.md)
*   [Parameters](./price_oscillator.md)
*   [Examples](./price_oscillator.md)
*   [Source Code](./price_oscillator.md)