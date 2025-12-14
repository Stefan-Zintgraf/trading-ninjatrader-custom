**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Disparity Index](./disparity_index.md)

# Disparity Index

# Disparity Index

## [Description](./disparity_index.md)

The Disparity Index that measures the difference between the price and an exponential moving average. A value greater could suggest bullish momentum, while a value less than zero could suggest bearish momentum.

## [Syntax](./disparity_index.md)

`DisparityIndex(int period)`

`DisparityIndex(ISeries<double> input, int period)`

## [Return Value](./disparity_index.md)

**double;** Accessing this method via an index value **int barsAgo** returns the indicator value of the referenced bar.

## [Parameters](./disparity_index.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./disparity_index.md)

```csharp
// Prints the current value of a 15 period Disparity Index
double value = DisparityIndex(15)[0];
Print("The current Disparity Index value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./disparity_index.md)
*   [Syntax](./disparity_index.md)
*   [Return Value](./disparity_index.md)
*   [Parameters](./disparity_index.md)
*   [Examples](./disparity_index.md)