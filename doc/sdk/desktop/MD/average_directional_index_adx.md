**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Average Directional Index (ADX)](./average_directional_index_adx.md)

# Average Directional Index (ADX)

# Average Directional Index (ADX)

## [Description](./average_directional_index_adx.md)

An indicator used in technical analysis as an objective value for the strength of trend. ADX is non\-directional so it will quantify a trend's strength regardless of whether it is up or down. ADX is usually plotted in a chart window along with two lines known as the DMI (Directional Movement Indicators). ADX is derived from the relationship of the DMI lines.

... Courtesy of [Investopedia](http://investopedia.com/terms/a/adx.asp)

## [Syntax](./average_directional_index_adx.md)

`ADX(int period)`

`ADX(ISeries<`double`> input, int period)`

**Returns default value**

`ADX(int period)[int barsAgo]`

`ADX(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./average_directional_index_adx.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./average_directional_index_adx.md)

Parameter

Description

input

Indicator source data

period

Number of bars used in the calculation

## [Examples](./average_directional_index_adx.md)

```csharp
// Prints the current value of a 20 period ADX
double value = ADX(20)[0];
Print("The current ADX value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./average_directional_index_adx.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./average_directional_index_adx.md)
*   [Syntax](./average_directional_index_adx.md)
*   [Return Value](./average_directional_index_adx.md)
*   [Parameters](./average_directional_index_adx.md)
*   [Examples](./average_directional_index_adx.md)
*   [Source Code](./average_directional_index_adx.md)