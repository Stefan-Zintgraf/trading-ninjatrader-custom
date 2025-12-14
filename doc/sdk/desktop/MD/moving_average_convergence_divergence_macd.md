**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average Convergence-Divergence (MACD)](./moving_average_convergence_divergence_macd.md)

# Moving Average Convergence-Divergence (MACD)

# Moving Average Convergence\-Divergence (MACD)

## [Description](./moving_average_convergence_divergence_macd.md)

MACD uses moving averages, which are lagging indicators, to include some trend\-following characteristics. These lagging indicators are turned into a momentum oscillator by subtracting the longer moving average from the shorter moving average.

... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_MACD1.html)

## [Syntax](./moving_average_convergence_divergence_macd.md)

`MACD(int fast, int slow, int smooth)`

`MACD(ISeries<double> input, int fast, int slow, int smooth)`

**Returns MACD value**

`MACD(int fast, int slow, int smooth)[int barsAgo]`

`MACD(ISeries<double> input, int fast, int slow, int smooth)[int barsAgo]`

**Returns average value**

`MACD(int fast, int slow, int smooth).Avg[int barsAgo]`

`MACD(ISeries<double> input, int fast, int slow, int smooth).Avg[int barsAgo]`

**Returns difference value**

`MACD(int fast, int slow, int smooth).Diff[int barsAgo]`

`MACD(ISeries<double> input, int fast, int slow, int smooth).Diff[int barsAgo]`

## [Return Value](./moving_average_convergence_divergence_macd.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_convergence_divergence_macd.md)

fast

The number of bars to calculate the fast [**EMA**](./moving_average_exponential_ema.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

slow

The numbers of bars to calculate the slow EMA

smooth

The number of bars to calculate the EMA signal line

## [Examples](./moving_average_convergence_divergence_macd.md)

```csharp
// Prints the current MACD value
double value = MACD(12, 26, 9)[0];
Print("The current MACD value is " + value.ToString());

// Prints the current MACD average value
double value = MACD(12, 26, 9).Avg[0];
Print("The current MACD average value is " + value.ToString());

// Prints the current MACD difference value
double value = MACD(12, 26, 9).Diff[0];
Print("The current MACD difference value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_convergence_divergence_macd.md)

You can view this indicator method source code by selecting the menu New > **NinjaScript** Editor > Indicators within the **NinjaTrader** Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_convergence_divergence_macd.md)
*   [Syntax](./moving_average_convergence_divergence_macd.md)
*   [Return Value](./moving_average_convergence_divergence_macd.md)
*   [Parameters](./moving_average_convergence_divergence_macd.md)
*   [Examples](./moving_average_convergence_divergence_macd.md)
*   [Source Code](./moving_average_convergence_divergence_macd.md)