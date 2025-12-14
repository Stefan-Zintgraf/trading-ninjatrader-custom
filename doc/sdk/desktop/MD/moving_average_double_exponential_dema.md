**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average - Double Exponential (DEMA)](./moving_average_double_exponential_dema.md)

# Moving Average - Double Exponential (DEMA)

# Moving Average \- Double Exponential (DEMA)

## [Description](./moving_average_double_exponential_dema.md)

The Double Exponential Moving Average (DEMA) is a combination of a single exponential moving average and a double exponential moving average. The advantage is that gives a reduced amount of lag time than either of the two separate moving averages alone.

## [Syntax](./moving_average_double_exponential_dema.md)

`DEMA(int period)`

`DEMA(ISeries<double> input, int period)`

**Returns default value**

`DEMA(int period)[int barsAgo]`

`DEMA(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./moving_average_double_exponential_dema.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_double_exponential_dema.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./moving_average_double_exponential_dema.md)

```csharp
// Prints the current value of a 20 period DEMA using default price type**
double value = DEMA(20)[0];
Print("The current DEMA value is " + value.ToString());
// Prints the current value of a 20 period DEMA using high price type**
double value = DEMA(High, 20)[0];
Print("The current DEMA value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./moving_average_double_exponential_dema.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./moving_average_double_exponential_dema.md)
*   [Syntax](./moving_average_double_exponential_dema.md)
*   [Return Value](./moving_average_double_exponential_dema.md)
*   [Parameters](./moving_average_double_exponential_dema.md)
*   [Examples](./moving_average_double_exponential_dema.md)
*   [Source Code](./moving_average_double_exponential_dema.md)