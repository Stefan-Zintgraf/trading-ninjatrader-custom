**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Relative Vigor Index](./relative_vigor_index.md)

# Relative Vigor Index

# Relative Vigor Index

## [Description](./relative_vigor_index.md)

The Relative Vigor Index measures the strength of a trend by comparing an instruments closing price to its price range. It's based on the fact that prices tend to close higher than they open in up trends, and closer lower than they open in downtrends.

## [Syntax](./relative_vigor_index.md)

`RelativeVigorIndex(int period)`

`RelativeVigorIndex(ISeries<double> input, int period)`

## [Return Value](./relative_vigor_index.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./relative_vigor_index.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./relative_vigor_index.md)

```csharp
// Prints the current value of a 10 period Relative Vigor Index
double value = RelativeVigorIndex(10)[0];
Print("The current Relative Vigor Index value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./relative_vigor_index.md)
*   [Syntax](./relative_vigor_index.md)
*   [Return Value](./relative_vigor_index.md)
*   [Parameters](./relative_vigor_index.md)
*   [Examples](./relative_vigor_index.md)