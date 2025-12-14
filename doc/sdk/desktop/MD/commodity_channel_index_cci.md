**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Commodity Channel Index (CCI)](./commodity_channel_index_cci.md)

# Commodity Channel Index (CCI)

# Commodity Channel Index (CCI)

## [Description](./commodity_channel_index_cci.md)

Developed by Donald Lambert, the Commodity Channel Index (CCI) was designed to identify cyclical turns in commodities. The assumption behind the indicator is that commodities (or stocks or bonds) move in cycles, with highs and lows coming at periodic intervals.

... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_CCI.html)

## [Syntax](./commodity_channel_index_cci.md)

`CCI(int period)`

`CCI(ISeries<double> input, int period)`

**Returns default value**

`CCI(int period)[int barsAgo]`

`CCI(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./commodity_channel_index_cci.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./commodity_channel_index_cci.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./commodity_channel_index_cci.md)

```csharp

// Prints the current value of a 20 period CCI using default price type
double value = CCI(20)[0];
Print("The current CCI value is " + value.ToString());

// Prints the current value of a 20 period CCI using high price type
double value = CCI(High, 20)[0];
Print("The current CCI value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./commodity_channel_index_cci.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./commodity_channel_index_cci.md)
*   [Syntax](./commodity_channel_index_cci.md)
*   [Return Value](./commodity_channel_index_cci.md)
*   [Parameters](./commodity_channel_index_cci.md)
*   [Examples](./commodity_channel_index_cci.md)
*   [Source Code](./commodity_channel_index_cci.md)