**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Momentum](./momentum.md)

# Momentum

# Momentum

## [Description](./momentum.md)

By measuring the amount that a security's price has changed over a given time span, the Momentum indicator provides an indication of a market's velocity and to some degree, a measure of the extent to which a trend still holds true. It can also be helpful in spotting likely reversal points.

## [Syntax](./momentum.md)

`Momentum(int period)`

`Momentum(ISeries<double> input, int period)`

**Returns default value**

`Momentum(int period)[int barsAgo]`

`Momentum(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./momentum.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./momentum.md)

Parameter

Description

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./momentum.md)

```csharp
// Prints the current value of a 20 period Momentum using default price type
double value = Momentum(20)[0];
Print("The current Momentum value is " + value.ToString());
  
// Prints the current value of a 20 period Momentum using high price type
double value = Momentum(High, 20)[0];
Print("The current Momentum value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./momentum.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./momentum.md)
*   [Syntax](./momentum.md)
*   [Return Value](./momentum.md)
*   [Parameters](./momentum.md)
*   [Examples](./momentum.md)
*   [Source Code](./momentum.md)