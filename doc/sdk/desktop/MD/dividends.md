**Path**: [MasterInstrument](./masterinstrument.md) > [Dividends](./dividends.md)

# Dividends

# Dividends

## [Definition](./dividends.md)

An collection of Dividends configured for the **Master Instrument properties** used in for stocks.

## [Property Value](./dividends.md)

A collection of Dividends configured for the current instrument.

Possible values are:

Amount

Date

A **double** value representing the amount in dollars which was paid on the date of the dividend

A DateTime structure representing the date of the dividend

## [Syntax](./dividends.md)

`Bars.Instrument.MasterInstrument.Dividends`

## [Examples](./dividends.md)

```csharp
foreach(Dividend dividends in Bars.Instrument.MasterInstrument.Dividends)
{
   Print(dividends.Amount);
   Print(dividends.Date);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./dividends.md)
*   [Property Value](./dividends.md)
*   [Syntax](./dividends.md)
*   [Examples](./dividends.md)