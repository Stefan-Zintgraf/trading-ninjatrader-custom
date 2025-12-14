**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Standard Deviation (StdDev)](./standard_deviation_stddev.md)

# Standard Deviation (StdDev)

# Standard Deviation (StdDev)

## [Description](./standard_deviation_stddev.md)

In probability theory and statistics, **standard deviation** is a measure of the variability or dispersion of a population, a data set, or a probability distribution. A low **standard deviation** indicates that the data points tend to be very close to the same value (the mean), while high **standard deviation** indicates that the data are “spread out” over a large range of values.

... Courtesy of [Wikipedia](https://en.wikipedia.org/wiki/Standard_deviation)

## [Syntax](./standard_deviation_stddev.md)

`StdDev(int period)`

`StdDev(ISeries<double> input, int period)`

**Returns default value**

`StdDev(int period)[int barsAgo]`

`StdDev(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./standard_deviation_stddev.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./standard_deviation_stddev.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./standard_deviation_stddev.md)

```csharp
// Prints the current value of a 20 period **StdDev** using default price type
double value = StdDev(20)[0];
Print("The current **StdDev** value is " + value.ToString());

// Prints the current value of a 20 period **StdDev** using high price type
double value = StdDev(High, 20)[0];
Print("The current **StdDev** value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./standard_deviation_stddev.md)

You can view this indicator method source code by selecting the menu New > **NinjaScript** Editor > Indicators within the **NinjaTrader** Control Center window.

#### ON THIS PAGE

*   [Description](./standard_deviation_stddev.md)
*   [Syntax](./standard_deviation_stddev.md)
*   [Return Value](./standard_deviation_stddev.md)
*   [Parameters](./standard_deviation_stddev.md)
*   [Examples](./standard_deviation_stddev.md)
*   [Source Code](./standard_deviation_stddev.md)