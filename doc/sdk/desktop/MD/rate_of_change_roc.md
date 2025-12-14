**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Rate of Change (ROC)](./rate_of_change_roc.md)

# Rate of Change (ROC)

# Rate of Change (ROC)

## [Description](./rate_of_change_roc.md)

The Rate of Change (ROC) indicator is a very simple yet effective momentum oscillator that measures the percent change in price from one period to the next. The ROC calculation compares the current price with the price n periods ago.

... Courtesy of [StockCharts](https://chartschool.stockcharts.com/table-of-contents/technical-indicators-and-overlays/technical-indicators/rate-of-change-roc)

## [Syntax](./rate_of_change_roc.md)

`ROC(int period)`

`ROC(ISeries<double> input, int period)`

**Returns default value**

`ROC(int period)[int barsAgo]`

`ROC(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./rate_of_change_roc.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./rate_of_change_roc.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./rate_of_change_roc.md)

```csharp
Prints the current value of a 20 period ROC using default price type
double value = ROC(20)[0];
Print("The current ROC value is " + value.ToString());

// Prints the current value of a 20 period ROC using high price type
double value = ROC(High, 20)[0];
Print("The current ROC value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./rate_of_change_roc.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./rate_of_change_roc.md)
*   [Syntax](./rate_of_change_roc.md)
*   [Return Value](./rate_of_change_roc.md)
*   [Parameters](./rate_of_change_roc.md)
*   [Examples](./rate_of_change_roc.md)
*   [Source Code](./rate_of_change_roc.md)