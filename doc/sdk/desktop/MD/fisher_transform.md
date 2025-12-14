**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Fisher Transform](./fisher_transform.md)

# Fisher Transform

# Fisher Transform

## [Description](./fisher_transform.md)

With distinct turning points and a rapid response time, the Fisher Transform uses the assumption that while prices do not have a normal or Gaussian probability density function (that familiar bell\-shaped curve), you can create a nearly Gaussian probability density function by normalizing price (or an indicator such as **RSI**) and applying the Fisher Transform. Use the resulting peak swings to clearly identify price reversals.

## [Syntax](./fisher_transform.md)

`FisherTransform(int period)`

`FisherTransform(ISeries<double> input, int period)`

**Returns default value**

`FisherTransform(int period)[int barsAgo]`

`FisherTransform(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./fisher_transform.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./fisher_transform.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./fisher_transform.md)

```csharp
// Prints the current value of a 10 period using default (median) price type
double value = FisherTransform(10)[0];
Print("The current Fisher Transform value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./fisher_transform.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./fisher_transform.md)
*   [Syntax](./fisher_transform.md)
*   [Return Value](./fisher_transform.md)
*   [Parameters](./fisher_transform.md)
*   [Examples](./fisher_transform.md)
*   [Source Code](./fisher_transform.md)