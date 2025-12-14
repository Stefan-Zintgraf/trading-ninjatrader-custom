**Path**: [System Indicator Methods](./system_indicator_methods.md) > [R-squared](./r_squared.md)

# R-squared

# R\-squared

## [Description](./r_squared.md)

The **r\-squared** indicator calculates how well the price approximates a linear regression line. The indicator gets its name from the calculation, which is, the square of the correlation coefficient (referred to in mathematics by the Greek letter rho, or r). The range of the **r\-squared** is from zero to one.

... Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=rsquared.htm)

## [Syntax](./r_squared.md)

`RSquared(int period)`

`RSquared(ISeries<double> input, int period)`

**Returns default value**

`RSquared(int period)[int barsAgo]`

`RSquared(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./r_squared.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./r_squared.md)

Parameter

Description

input

Indicator source data ([Series<\`T>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./r_squared.md)

```csharp
// Prints the current value of a 20 period R-squared using default price type
double value = RSquared(20)[0];
Print("The current R-squared value is " + value.ToString());

// Prints the current value of a 20 period R-squared using high price type
double value = RSquared(High, 20)[0];
Print("The current R-squared value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./r_squared.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./r_squared.md)
*   [Syntax](./r_squared.md)
*   [Return Value](./r_squared.md)
*   [Parameters](./r_squared.md)
*   [Examples](./r_squared.md)
*   [Source Code](./r_squared.md)