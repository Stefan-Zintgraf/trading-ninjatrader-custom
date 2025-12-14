**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Linear Regression](./linear_regression.md)

# Linear Regression

# Linear Regression

## [Description](./linear_regression.md)

The Linear Regression Indicator plots the trend of a security's price over time. That trend is determined by calculating a Linear Regression Trendline using the least squares method. This ensures the minimum distance between the data points and a Linear Regression Trendline.

## [Syntax](./linear_regression.md)

`LinReg(int period)`

`LinReg(ISeries<double> input, int period)`

**Returns default value**

`LinReg(int period)[int barsAgo]`

`LinReg(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./linear_regression.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./linear_regression.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./linear_regression.md)

```csharp

// Prints the current value of a 20 period LinReg using default price type
double value = LinReg(20)[0];
Print("The current LinReg value is " + value.ToString());

// Prints the current value of a 20 period LinReg using high price type
double value = LinReg(High, 20)[0];
Print("The current LinReg value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./linear_regression.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./linear_regression.md)
*   [Syntax](./linear_regression.md)
*   [Return Value](./linear_regression.md)
*   [Parameters](./linear_regression.md)
*   [Examples](./linear_regression.md)
*   [Source Code](./linear_regression.md)