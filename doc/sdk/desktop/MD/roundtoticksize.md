**Path**: [MasterInstrument](./masterinstrument.md) > [RoundToTickSize()](./roundtoticksize.md)

# RoundToTickSize()

# RoundToTickSize()

## [Definition](./roundtoticksize.md)

Returns a value that is rounded up to the nearest valid value evenly divisible by the instrument's tick size.

## [Method Return Value](./roundtoticksize.md)

A **double** value.

## [Syntax](./roundtoticksize.md)

`Instrument.MasterInstrument.RoundToTickSize(double price)`

## [Parameters](./roundtoticksize.md)

Parameter

Description

**price**

A **double** value representing a price

## [Examples](./roundtoticksize.md)

```csharp
//Takes the last 3 closes, divides them by 3, and rounds the value up to the nearest valid tick size
Value[0] = Instrument.MasterInstrument.RoundToTickSize((Close[0] + Close[1] + Close[2]) / 3);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./roundtoticksize.md)
*   [Method Return Value](./roundtoticksize.md)
*   [Syntax](./roundtoticksize.md)
*   [Parameters](./roundtoticksize.md)
*   [Examples](./roundtoticksize.md)