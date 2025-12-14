**Path**: [System Indicator Methods](./system_indicator_methods.md) > [On Balance Volume (OBV)](./on_balance_volume_obv.md)

# On Balance Volume (OBV)

# On Balance Volume (OBV)

## [Description](./on_balance_volume_obv.md)

OBV is a simple indicator that adds a period's volume when the close is up and subtracts the period's volume when the close is down. A cumulative total of the volume additions and subtractions forms the OBV line. This line can then be compared with the price chart of the underlying security to look for divergences or confirmation.

... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic-obv.htm)

## [Syntax](./on_balance_volume_obv.md)

`OBV()`

`OBV(ISeries<double> input)`

**Returns default value**

`OBV()[int barsAgo]`

`OBV(ISeries<double> input)[int barsAgo]`

## [Return Value](./on_balance_volume_obv.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./on_balance_volume_obv.md)

Parameter

Description

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

## [Examples](./on_balance_volume_obv.md)

```csharp
// Prints the current value of OBV
double value = OBV()[0];
Print("The current OBV value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./on_balance_volume_obv.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./on_balance_volume_obv.md)
*   [Syntax](./on_balance_volume_obv.md)
*   [Return Value](./on_balance_volume_obv.md)
*   [Parameters](./on_balance_volume_obv.md)
*   [Examples](./on_balance_volume_obv.md)
*   [Source Code](./on_balance_volume_obv.md)