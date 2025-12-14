**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Standard Error (StdError)](./standard_error_stderror.md)

# Standard Error (StdError)

# Standard Error (StdError)

## [Description](./standard_error_stderror.md)

The standard error of a method of measurement or estimation is the standard deviation of the sampling distribution associated with the estimation method. The term may also be used to refer to an estimate of that standard deviation, derived from a particular sample used to compute the estimate.

... Courtesy of [Wikipedia](http://en.wikipedia.org/wiki/Standard_error_(statistics))

## [Syntax](./standard_error_stderror.md)

`StdError(int period)`

`StdError(ISeries<double> input, int period)`

**Returns default value which is the mid line (also known as linear regression)**

`StdError(int period)[int barsAgo]`

`StdError(ISeries<double> input, int period)[int barsAgo]`

**Returns upper value**

`StdError(int period).Upper[int barsAgo]`

`StdError(ISeries<double> input, int period).Upper[int barsAgo]`

**Returns lower value**

`StdError(int period).Lower[int barsAgo]`

`StdError(ISeries<double> input, int period).Lower[int barsAgo]`

## [Return Value](./standard_error_stderror.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./standard_error_stderror.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./standard_error_stderror.md)

```csharp
// Prints the current upper value of a 20 period **StdError** using default price type
double value = StdError(20).Upper[0];
Print("The current upper Standard Error value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./standard_error_stderror.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./standard_error_stderror.md)
*   [Syntax](./standard_error_stderror.md)
*   [Return Value](./standard_error_stderror.md)
*   [Parameters](./standard_error_stderror.md)
*   [Examples](./standard_error_stderror.md)
*   [Source Code](./standard_error_stderror.md)