**Path**: [MasterInstrument](./masterinstrument.md) > [Splits](./splits.md)

# Splits

# Splits

## [Definition](./splits.md)

Indicates the Splits that have been configured for the **Master Instrument properties** used in for stocks.

## [Property Value](./splits.md)

A collection of Splits configured for the current instrument.

Possible values are:

Date

Factor

A DateTime structure representing the date of the split

A **double** value representing the number of points the stock split

## [Syntax](./splits.md)

`Bars.Instrument.MasterInstrument.Splits`

## [Examples](./splits.md)

```csharp
 foreach (Split split in Bars.Instrument.MasterInstrument.Splits)
{
     Print(split.Date);
     Print(split.Factor);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./splits.md)
*   [Property Value](./splits.md)
*   [Syntax](./splits.md)
*   [Examples](./splits.md)