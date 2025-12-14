**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Linear Regression Intercept](./linear_regression_intercept.md)

# Linear Regression Intercept

# Linear Regression Intercept

## [Description](./linear_regression_intercept.md)

The Linear Regression Intercept provides the intercept value of the **Linear Regression** trendline.

## [Syntax](./linear_regression_intercept.md)

`LinRegIntercept(int period)`

`LinRegIntercept(ISeries<double> input, int period)`

**Returns default value**

`LinRegIntercept(int period)[int barsAgo]`

`LinRegIntercept(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./linear_regression_intercept.md)

**double**; Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./linear_regression_intercept.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./linear_regression_intercept.md)

```csharp
// Prints the current intercept value of a 20 period LinReg using default price type
double value = LinRegIntercept(20)[0];
Print("The current intercept value is " + value.ToString());
// Prints the current intercept value of a 20 period LinReg using high price type
double value = LinRegIntercept(High, 20)[0];
Print("The current intercept value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./linear_regression_intercept.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./linear_regression_intercept.md)
*   [Syntax](./linear_regression_intercept.md)
*   [Return Value](./linear_regression_intercept.md)
*   [Parameters](./linear_regression_intercept.md)
*   [Examples](./linear_regression_intercept.md)
*   [Source Code](./linear_regression_intercept.md)