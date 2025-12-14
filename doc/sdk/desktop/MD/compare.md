**Path**: [MasterInstrument](./masterinstrument.md) > [Compare()](./compare.md)

# Compare()

# Compare()

## [Definition](./compare.md)

Compares two price values with respect to the Instrument **TickSize** to ensure accuracy when dealing with floating point math.

## [Method Return Value](./compare.md)

An **int** value.

*   A value of "1" is returned if price1 is greater than price2.
*   A value of "\-1" is returned if price1 is less than price2.
*   A value of "0" if price1 is equal to price2.

## [Syntax](./compare.md)

`Instrument.MasterInstrument.Compare(double price1, double price2)`

## [Parameters](./compare.md)

price1

A **double** value representing a price.

price2

A **double** value representing a price.

## [Examples](./compare.md)

```csharp
double newPrice = Close[0] + High[0] + Open[0];
if (Instrument.MasterInstrument.Compare(newPrice, Close[1]) == 1)
     // Do something since price1 is greater than price2


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./compare.md)
*   [Method Return Value](./compare.md)
*   [Syntax](./compare.md)
*   [Parameters](./compare.md)
*   [Examples](./compare.md)