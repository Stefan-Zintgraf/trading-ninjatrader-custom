**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Hull (HMA)](./moving_average_hull_hma.md)

# Moving Average - Hull (HMA)

# Moving Average \- Hull (HMA)

## [Description](./moving_average_hull_hma.md)

The HMA manages to keep up with rapid changes in price activity whilst having superior smoothing over an SMA of the same period. The HMA employs weighted moving averages and dampens the smoothing effect (and resulting lag) by using the square root of the period instead of the actual period itself. Developed by Alan Hull.

## [Syntax](./moving_average_hull_hma.md)

`HMA(int period)`

`HMA(ISeries<double> input, int period)`

**Returns default value**

`HMA(int period)[int barsAgo]`

`HMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_hull_hma.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_hull_hma.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./moving_average_hull_hma.md)

```csharp
// Prints the current value of a 20 period HMA using default price type
double value = HMA(20)[0];
Print("The current HMA value is " + value.ToString());

// Prints the current value of a 20 period HMA using high price type
double value = HMA(High, 20)[0];
Print("The current HMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_hull_hma.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_hull_hma.md)
*   [Syntax](./moving_average_hull_hma.md)
*   [Return Value](./moving_average_hull_hma.md)
*   [Parameters](./moving_average_hull_hma.md)
*   [Examples](./moving_average_hull_hma.md)
*   [Source Code](./moving_average_hull_hma.md)