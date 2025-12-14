**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Triangular (TMA)](./moving_average_triangular_tma.md)

# Moving Average - Triangular (TMA)

# Moving Average \- Triangular (TMA)

## [Description](./moving_average_triangular_tma.md)

The Triangular Moving Average is a form of **Weighted Moving Average** wherein the weights are assigned in a triangular pattern. For example, the weights for a 7 period Triangular Moving Average would be 1, 2, 3, 4, 3, 2, 1. This gives more weight to the middle of the time series and less weight to the oldest and newest data.

## [Syntax](./moving_average_triangular_tma.md)

`TMA(int period)`

`TMA(ISeries<double> input, int period)`

**Returns default value**

`TMA(int period)[int barsAgo]`

`TMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_triangular_tma.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_triangular_tma.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./moving_average_triangular_tma.md)

```csharp
// Prints the current value of a 20 period TMA using default price type
double value = TMA(20)[0];
Print("The current TMA value is " + value.ToString());
  
// Prints the current value of a 20 period TMA using high price type
double value = TMA(High, 20)[0];
Print("The current TMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_triangular_tma.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_triangular_tma.md)
*   [Syntax](./moving_average_triangular_tma.md)
*   [Return Value](./moving_average_triangular_tma.md)
*   [Parameters](./moving_average_triangular_tma.md)
*   [Examples](./moving_average_triangular_tma.md)
*   [Source Code](./moving_average_triangular_tma.md)