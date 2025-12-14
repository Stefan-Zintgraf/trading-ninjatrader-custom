**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Linear Regression Slope](./linear_regression_slope.md)

# Linear Regression Slope

# Linear Regression Slope

## [Description](./linear_regression_slope.md)

The Linear Regression Slope provides the slope value of the **Linear Regression** trendline.

## [Syntax](./linear_regression_slope.md)

`LinRegSlope(int period)`

`LinRegSlope(ISeries<double> input, int period)`

**Returns default value**

`LinRegSlope(int period)[int barsAgo]`

`LinRegSlope(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./linear_regression_slope.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./linear_regression_slope.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./linear_regression_slope.md)

```csharp

// Prints the current slope value of a 20 period LinReg using default price type
double value = LinRegSlope(20)[0];
Print("The current slope value is " + value.ToString());

// Prints the current slope value of a 20 period LinReg using high price type
double value = LinRegSlope(High, 20)[0];
Print("The current slope value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./linear_regression_slope.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./linear_regression_slope.md)
*   [Syntax](./linear_regression_slope.md)
*   [Return Value](./linear_regression_slope.md)
*   [Parameters](./linear_regression_slope.md)
*   [Examples](./linear_regression_slope.md)
*   [Source Code](./linear_regression_slope.md)