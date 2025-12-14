**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Chaikin Oscillator](./chaikin_oscillator.md)

# Chaikin Oscillator

# Chaikin Oscillator

## [Description](./chaikin_oscillator.md)

The Chaikin Oscillator is simply the Moving Average Convergence Divergence indicator (MACD) applied to the Accumulation/Distribution Line. The formula is the difference between the 3\-day exponential moving average and the 10\-day exponential moving average of the Accumulation/Distribution Line. Just as the MACD\-Histogram is an indicator to predict moving average crossovers in MACD, the Chaikin Oscillator is an indicator to predict changes in the Accumulation/Distribution Line.

... Courtesy of [StockCharts](https://chartschool.stockcharts.com/table-of-contents/technical-indicators-and-overlays/technical-indicators/chaikin-oscillator)

## [Syntax](./chaikin_oscillator.md)

`ChaikinOscillator(int fast, int slow)`

`ChaikinOscillator(ISeries<double> input, int fast, int slow)`

**Returns default value**

`ChaikinOscillator(int fast, int slow)[int barsAgo]`

`ChaikinOscillator**[ISeries<double> input, int fast, int slow](int barsAgo)`

## [Return Value](./chaikin_oscillator.md)

**double;** Accessing this method via an index value \[int barsAgo\] returns the indicator value of the referenced bar.

## [Parameters](./chaikin_oscillator.md)

fast

input

slow

The number of bars to calculate the fast **EMA**

Indicator source data ([Series<`T`\>](./seriest.md))

The number of bars to calculate the slow **EMA**

## [Examples](./chaikin_oscillator.md)

```csharp
// Prints the current value of a ChaikinOscillator using default price type
double value = ChaikinOscillator(3, 10)[0];
Print("The current ChaikinOscillator value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./chaikin_oscillator.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./chaikin_oscillator.md)
*   [Syntax](./chaikin_oscillator.md)
*   [Return Value](./chaikin_oscillator.md)
*   [Parameters](./chaikin_oscillator.md)
*   [Examples](./chaikin_oscillator.md)
*   [Source Code](./chaikin_oscillator.md)