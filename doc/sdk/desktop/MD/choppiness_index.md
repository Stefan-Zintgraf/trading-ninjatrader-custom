**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Choppiness Index](./choppiness_index.md)

# Choppiness Index

# Choppiness Index

## [Description](./choppiness_index.md)

The Choppiness Index is designed to determine if the market is choppy (trading sideways) or not choppy (trading within a trend in either direction).

## [Syntax](./choppiness_index.md)

`ChoppinessIndex(int period)`

`ChoppinessIndex(ISeries<double> input, int period)`

## [Return Value](./choppiness_index.md)

**double;** Accessing this method via an index value **int barsAgo** returns the indicator value of the referenced bar.

## [Parameters](./choppiness_index.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./choppiness_index.md)

```csharp
// Prints the current value of a 14 period Choppiness Index
double value = ChoppinessIndex(14)[0];
Print("The current Choppiness Index value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./choppiness_index.md)
*   [Syntax](./choppiness_index.md)
*   [Return Value](./choppiness_index.md)
*   [Parameters](./choppiness_index.md)
*   [Examples](./choppiness_index.md)