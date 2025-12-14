**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Forecast Oscillator (FOSC)](./forecast_oscillator_fosc.md)

# Forecast Oscillator (FOSC)

# Forecast Oscillator (FOSC)

## [Description](./forecast_oscillator_fosc.md)

The Forecast Oscillator calculates the percentage difference between the actual price and the Time Series Forecast (the endpoint of a linear regression line). When the price and the forecast are equal, the Oscillator is zero. When the price is greater than the forecast, the Oscillator is greater than zero. When the price is less than the forecast, the Oscillator is less than zero.

... Courtesy of [FM Labs](http://www.fmlabs.com/reference/default.htm?url=ForecastOscillator.htm)

## [Syntax](./forecast_oscillator_fosc.md)

`FOSC(int period)`

`FOSC(ISeries<double> input, int period)`

**Returns default value**

`FOSC(int period)[int barsAgo]`

`FOSC(ISeries<double> input, int period**)[int barsAgo]`

## [Return Value](./forecast_oscillator_fosc.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./forecast_oscillator_fosc.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./forecast_oscillator_fosc.md)

```csharp
// Evaluates if the current bar **FOSC** is above zero
if (FOSC(14)[0] > 0)
   Print("FOSC is above zero indicating prices may rise");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./forecast_oscillator_fosc.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./forecast_oscillator_fosc.md)
*   [Syntax](./forecast_oscillator_fosc.md)
*   [Return Value](./forecast_oscillator_fosc.md)
*   [Parameters](./forecast_oscillator_fosc.md)
*   [Examples](./forecast_oscillator_fosc.md)
*   [Source Code](./forecast_oscillator_fosc.md)