**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Summation (SUM)](./summation_sum.md)

# Summation (SUM)

# Summation (SUM)

## [Description](./summation_sum.md)

Returns the sum of the values taken over a specified period.

## [Syntax](./summation_sum.md)

`SUM(int period)`

`SUM(ISeries<double> input, int period)`

**Returns default value**

`SUM(int period)[int barsAgo]`

`SUM(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./summation_sum.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./summation_sum.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./summation_sum.md)

```csharp
// Prints the current value of a 20 period SUM using default price type
double value = SUM(20)[0];
Print("The current SUM value is " + value.ToString());

// Prints the current value of a 20 period SUM using high price type
double value = SUM(High, 20)[0];
Print("The current SUM value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./summation_sum.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./summation_sum.md)
*   [Syntax](./summation_sum.md)
*   [Return Value](./summation_sum.md)
*   [Parameters](./summation_sum.md)
*   [Examples](./summation_sum.md)
*   [Source Code](./summation_sum.md)