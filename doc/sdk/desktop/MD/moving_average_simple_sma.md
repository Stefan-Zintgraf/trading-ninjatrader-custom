**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Simple (SMA)](./moving_average_simple_sma.md)

# Moving Average - Simple (SMA)

# Moving Average \- Simple (SMA)

## [Description](./moving_average_simple_sma.md)

The Simple Moving Average is calculated by summing the closing prices of the security for a period of time and then dividing this total by the number of time periods. Sometimes called an arithmetic moving average, the SMA is basically the average stock price over time.

## [Syntax](./moving_average_simple_sma.md)

`SMA(int period)`

`SMA(ISeries<double> input, int period)`

\*\*Returns default value \*\*

`SMA(int period)[int barsAgo]`

`SMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_simple_sma.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_simple_sma.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./moving_average_simple_sma.md)

```csharp
// Prints the current value of a 20 period SMA using default price type
double value = SMA(20)[0];
Print("The current SMA value is " + value.ToString());

// Prints the current value of a 20 period SMA using high price type**
double value = SMA(High, 20)[0];
Print("The current SMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_simple_sma.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_simple_sma.md)
*   [Syntax](./moving_average_simple_sma.md)
*   [Return Value](./moving_average_simple_sma.md)
*   [Parameters](./moving_average_simple_sma.md)
*   [Examples](./moving_average_simple_sma.md)
*   [Source Code](./moving_average_simple_sma.md)