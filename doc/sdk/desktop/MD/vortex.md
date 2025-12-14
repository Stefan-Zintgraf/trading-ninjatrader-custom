**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Vortex](./vortex.md)

# Vortex

# Vortex

## [Description](./vortex.md)

The Vortex indicator is an oscillator used to identify trends. A bullish signal triggers when the VIPlus line crosses above the VIMinus line. A bearish signal triggers when the VIMinus line crosses above the VIPlus line.

## [Syntax](./vortex.md)

`Vortex(int period)`

`Vortex(ISeries<double> input, int period)`

**Returns VIPlus value**

`Vortex(int period).VIPlus[int barsAgo]`

`Vortex(ISeries<`double`> input, int period).VIPlus[int barsAgo]`

**Returns VIMinus value**

`Vortex(int period).VIMinus[int barsAgo]`

`Vortex(ISeries<double> input, int period).VIMinus[int barsAgo]`

## [Return Value](./vortex.md)

*   **double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar

## [Parameters](./vortex.md)

Property

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./vortex.md)

```csharp
// Prints the current VIPlus value of a 14 period Vortex
double valueP = Vortex(14).VIPlus[0];
Print("The current Vortex VIPlus value is " + valueP.ToString());

// Prints the current VIMinus value of a 14 period Vortex
double valueM = Vortex(14).VIMinus[0];
Print("The current Vortex VIMinusvalue is " + valueM.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./vortex.md)
*   [Syntax](./vortex.md)
*   [Return Value](./vortex.md)
*   [Parameters](./vortex.md)
*   [Examples](./vortex.md)