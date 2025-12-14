**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Parabolic SAR](./parabolic_sar.md)

# Parabolic SAR

# Parabolic SAR

## [Description](./parabolic_sar.md)

The parabolic SAR is a technical indicator that is used by many traders to determine the direction of an asset's momentum and the point in time when this momentum has a higher\-than\-normal probability of switching directions.

... Courtesy of [Investopedia](http://www.investopedia.com/articles/technical/02/042202.asp)

## [Syntax](./parabolic_sar.md)

`ParabolicSAR(double acceleration, double accelerationMax, double accelerationStep)`

`ParabolicSAR(ISeries<double> input, double acceleration, double accelerationMax, double accelerationStep)`

**Returns default value**

`ParabolicSAR(double acceleration, double accelerationMax, double accelerationStep)[int barsAgo]`

`ParabolicSAR(ISeries<double> input, double acceleration, double accelerationStep, double accelerationMax)[int barsAgo]`

## [Return Value](./parabolic_sar.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./parabolic_sar.md)

**acceleration**

Acceleration value

**accelerationStep**

Step value used to increment acceleration value

**accelerationMax**

Max acceleration value

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

## [Examples](./parabolic_sar.md)

```csharp
// Prints the current value of ParabolicSAR using default price type
double value = ParabolicSAR(0.02, 0.2, 0.02)[0];
Print("The current ParabolicSAR value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./parabolic_sar.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./parabolic_sar.md)
*   [Syntax](./parabolic_sar.md)
*   [Return Value](./parabolic_sar.md)
*   [Parameters](./parabolic_sar.md)
*   [Examples](./parabolic_sar.md)
*   [Source Code](./parabolic_sar.md)