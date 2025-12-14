**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Range](./range.md)

# Range

# Range

## [Description](./range.md)

Returns the range of a bar.

## [Syntax](./range.md)

`Range()`

`Range(ISeries<double> input)`

**Returns default value**

`Range()[int barsAgo]`

`Range(ISeries<double> input)[int barsAgo]`

## [Return Value](./range.md)

**double;** Accessing this method via an index value `[int barsAgo` returns the indicator value of the referenced bar.

## [Parameters](./range.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./range.md)

```csharp
// Prints the range of the current bar
double value = Range()[0];
Print("The current bar's range is " + value.ToString());

// Prints the 20 period simple moving average of range
double value = SMA(Range(), 20)[0];
Print("The 20 period average of range is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./range.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./range.md)
*   [Syntax](./range.md)
*   [Return Value](./range.md)
*   [Parameters](./range.md)
*   [Examples](./range.md)
*   [Source Code](./range.md)