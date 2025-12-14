**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Williams %R](./williams_r.md)

# Williams %R

# Williams %R

## [Description](./williams_r.md)

Developed by Larry Williams, Williams %R is a momentum indicator that works much like the [Stochastic Oscillator](./stochastics.md). It is especially popular for measuring overbought and oversold levels. The scale ranges from 0 to \-100 with readings from 0 to \-20 considered overbought, and readings from \-80 to \-100 considered oversold.

... Courtesy of [StockCharts](https://school.stockcharts.com/doku.php?id=technical_indicators:williams_r)

## [Syntax](./williams_r.md)

`WilliamsR(int period)`

`WilliamsR(ISeries<`double`> input, int period)`

**Returns default value**

`WilliamsR(int period)[int barsAgo]`

`WilliamsR(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./williams_r.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./williams_r.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./williams_r.md)

```csharp
// Prints the current value of a 20 period WilliamsR using default price type  
double value = WilliamsR(20)[0];  
Print("The current WilliamsR value is " + value.ToString());  
   
// Prints the current value of a 20 period WilliamsR using high price type  
double value = WilliamsR(High, 20)[0];  
Print("The current WilliamsR value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./williams_r.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./williams_r.md)
*   [Syntax](./williams_r.md)
*   [Return Value](./williams_r.md)
*   [Parameters](./williams_r.md)
*   [Examples](./williams_r.md)
*   [Source Code](./williams_r.md)