**Path**: [Analytical](./analytical.md) > [TickSize](./ticksize.md)

# TickSize

# TickSize

## [Definition](./ticksize.md)

The minimum fluctuation value which is always a value of 1\-tick for the corresponding master instrument.

## [Property Value](./ticksize.md)

A **double** value that represents the minimum fluctuation of an instrument.

## [Syntax](./ticksize.md)

`TickSize`

## [Examples](./ticksize.md)

```csharp
// Prints the ticksize to the output window
Print("The ticksize of this instrument is " + TickSize);

// Prints the value of the current bar low less one tick size  
double value = Low[0] - TickSize;  
Print(value);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ticksize.md)
*   [Property Value](./ticksize.md)
*   [Syntax](./ticksize.md)
*   [Examples](./ticksize.md)