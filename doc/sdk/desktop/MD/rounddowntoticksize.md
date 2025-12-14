**Path**: [MasterInstrument](./masterinstrument.md) > [RoundDownToTickSize()](./rounddowntoticksize.md)

# RoundDownToTickSize()

# RoundDownToTickSize()

## [Definition](./rounddowntoticksize.md)

Returns a value that is rounded down to the nearest valid value evenly divisible by the instrument's tick size.

## [Method Return Value](./rounddowntoticksize.md)

A **double** value.

## [Syntax](./rounddowntoticksize.md)

`Instrument.MasterInstrument.RoundDownToTickSize(double price)`

## [Parameters](./rounddowntoticksize.md)

Parameter

Description

**price**

A **double** value representing a price

## [Examples](./rounddowntoticksize.md)

```csharp
//Takes the last 3 closes, divides them by 3, and rounds the value down to the nearest valid tick size**
Value[0] = Instrument.MasterInstrument.RoundDownToTickSize((Close[0] + Close[1] + Close[2]) / 3);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./rounddowntoticksize.md)
*   [Method Return Value](./rounddowntoticksize.md)
*   [Syntax](./rounddowntoticksize.md)
*   [Parameters](./rounddowntoticksize.md)
*   [Examples](./rounddowntoticksize.md)