**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Time Series Forecast (TSF)](./time_series_forecast_tsf.md)

# Time Series Forecast (TSF)

# Time Series Forecast (TSF)

## [Description](./time_series_forecast_tsf.md)

The Time Series Forecast function displays the statistical trend of a security's price over a specified time period based on linear regression analysis. Instead of a straight linear regression trendline, the Time Series Forecast plots the last point of multiple linear regression trendlines. This is why this indicator may sometimes be referred to as the "moving linear regression" indicator or the "regression oscillator."

## [Syntax](./time_series_forecast_tsf.md)

`TSF(int forecast, int period)`

`TSF(ISeries<double> input, int forecast, int period)`

**Returns default value**

`TSF(int forecast, int period)[int barsAgo]`

`TSF(ISeries<double> input, int forecast, int period)[int barsAgo]`

## [Return Value](./time_series_forecast_tsf.md)

**double**; Accessing this method via an index value `int barsAgo` returns the indicator value of the referenced bar.

## [Parameters](./time_series_forecast_tsf.md)

Parameter

Description

**forecast**

Forecast period

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./time_series_forecast_tsf.md)

```csharp
// Prints the current value of a 20 period TSF using default price type
double value = TSF(3, 20)[0];
Print("The current TSF value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./time_series_forecast_tsf.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./time_series_forecast_tsf.md)
*   [Syntax](./time_series_forecast_tsf.md)
*   [Return Value](./time_series_forecast_tsf.md)
*   [Parameters](./time_series_forecast_tsf.md)
*   [Examples](./time_series_forecast_tsf.md)
*   [Source Code](./time_series_forecast_tsf.md)