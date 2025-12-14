**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - T3 (T3)](./moving_average_t3_t3.md)

# Moving Average - T3 (T3)

# Moving Average \- T3 (T3)

## [Description](./moving_average_t3_t3.md)

The T3 is a type of moving average, or smoothing function. It is based on the DEMA. The T3 takes the DEMA calculation and adds a vfactor which is between zero and 1. The resultant function is called the GD, or Generalized DEMA. A GD with vfactor of 1 is the same as the DEMA. A GD with a vfactor of zero is the same as an Exponential Moving Average. The T3 typically uses a vfactor of 0.7.

... Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=T3.htm)

## [Syntax](./moving_average_t3_t3.md)

`T3(int period, int tCount, double vFactor)`

`T3(ISeries<double> input, int period, int tCount, double vFactor)`

**Returns default value**

`T3(int period, int tCount, double vFactor)[int barsAgo]`

`T3(ISeries<double> input, int period, int tCount, double vFactor)[int barsAgo]`

## [Return Value](./moving_average_t3_t3.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_t3_t3.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

tCount

Number of smooth iterations

vFactor

A multiplier fudge factor

## [Examples](./moving_average_t3_t3.md)

```csharp
// Prints the current value of a 20 period T3 using default price type
double value = T3(20, 3, 0.7)[0];
Print("The current T3 value is " + value.ToString());

// Prints the current value of a 20 period T3 using high price type
double value = T3(High, 20, 3, 0.7)[0];
Print("The current T3 value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_t3_t3.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_t3_t3.md)
*   [Syntax](./moving_average_t3_t3.md)
*   [Return Value](./moving_average_t3_t3.md)
*   [Parameters](./moving_average_t3_t3.md)
*   [Examples](./moving_average_t3_t3.md)
*   [Source Code](./moving_average_t3_t3.md)