**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Chaikin Money Flow](./chaikin_money_flow.md)

# Chaikin Money Flow

# Chaikin Money Flow

## [Description](./chaikin_money_flow.md)

The formula for **Chaikin Money Flow** is the cumulative total of the Accumulation/Distribution Values for 21 periods divided by the cumulative total of volume for 21 periods.

... Courtesy of [StockCharts](https://chartschool.stockcharts.com/table-of-contents/technical-indicators-and-overlays/technical-indicators/chaikin-money-flow-cmf)

## [Syntax](./chaikin_money_flow.md)

`ChaikinMoneyFlow(int period)`

`ChaikinMoneyFlow(ISeries<double> input, int period)`

**Returns default value**

`ChaikinMoneyFlow(int period)[int barsAgo]`

`ChaikinMoneyFlow(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./chaikin_money_flow.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./chaikin_money_flow.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./chaikin_money_flow.md)

```csharp
// Prints the current value of a 20 period ChaikinMoneyFlow using default price type
double value = ChaikinMoneyFlow(20)[0];
Print("The current **ChaikinMoneyFlow** value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./chaikin_money_flow.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./chaikin_money_flow.md)
*   [Syntax](./chaikin_money_flow.md)
*   [Return Value](./chaikin_money_flow.md)
*   [Parameters](./chaikin_money_flow.md)
*   [Examples](./chaikin_money_flow.md)
*   [Source Code](./chaikin_money_flow.md)