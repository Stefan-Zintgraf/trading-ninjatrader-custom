**Path**: [MasterInstrument](./masterinstrument.md) > [Currency](./masterinstrument_currency.md)

# Currency

# Currency

## [Definition](./masterinstrument_currency.md)

Indicates the currency configured for the **Master Instrument properties**.

## [Property Value](./masterinstrument_currency.md)

A type of Currency which is configured for the current master instrument.

## [Syntax](./masterinstrument_currency.md)

`Bars.Instrument.MasterInstrument.Currency`

## [Examples](./masterinstrument_currency.md)

```csharp
if (Bars.Instrument.MasterInstrument.Currency != Currency.UsDollar)
{
    //Prints if the currency is not UsDollar and indicates what currency it is
    Print ("Warning: Instruments base currency is not UsDollar, it is " + Bars.Instrument.MasterInstrument.Currency);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./masterinstrument_currency.md)
*   [Property Value](./masterinstrument_currency.md)
*   [Syntax](./masterinstrument_currency.md)
*   [Examples](./masterinstrument_currency.md)