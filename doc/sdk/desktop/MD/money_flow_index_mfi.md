**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Money Flow Index (MFI)](./money_flow_index_mfi.md)

# Money Flow Index (MFI)

# Money Flow Index (MFI)

## [Description](./money_flow_index_mfi.md)

The Money Flow Index (MFI) is a momentum indicator that is similar to the Relative Strength Index (RSI) in both interpretation and calculation. However, MFI is a more rigid indicator in that it is volume\-weighted, and is therefore a good measure of the strength of money flowing in and out of a security.

... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_MFI.htm)

## [Syntax](./money_flow_index_mfi.md)

`MFI(int period)`

`MFI(ISeries<double> input, int period)`

**Returns default value**

`MFI(int period)[int barsAgo]`

`MFI(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./money_flow_index_mfi.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./money_flow_index_mfi.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./money_flow_index_mfi.md)

```csharp
// Prints the current value of a 20 period MFI using default price type
double value = MFI(20)[0];
Print("The current MFI value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./money_flow_index_mfi.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./money_flow_index_mfi.md)
*   [Syntax](./money_flow_index_mfi.md)
*   [Return Value](./money_flow_index_mfi.md)
*   [Parameters](./money_flow_index_mfi.md)
*   [Examples](./money_flow_index_mfi.md)
*   [Source Code](./money_flow_index_mfi.md)