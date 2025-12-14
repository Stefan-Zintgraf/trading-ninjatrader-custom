**Path**: [MasterInstrument](./masterinstrument.md) > [RolloverCollection](./rollovercollection.md)

# RolloverCollection

# RolloverCollection

## [Definition](./rollovercollection.md)

Indicates the rollovers that have been configured for the **Master Instrument properties** used in for futures.

## [Syntax](./rollovercollection.md)

`Bars.Instrument.MasterInstrument.RolloverCollection`

## [Property Value](./rollovercollection.md)

A **RolloversCollection** configured for the current instrument.

Possible values are:

Parameter

Description

ContractMonth

A DateTime structure representing the expiry month of a futures contract

Date

A DateTime structure representing the date of the rollover

Offset

A double value representing the number of points between contracts

## [Examples](./rollovercollection.md)

```csharp
foreach(var rollover in Bars.Instrument.MasterInstrument.RolloverCollection)
{
     Print(rollover.ContractMonth);
     Print(rollover.Date);
     Print(rollover.Offset);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./rollovercollection.md)
*   [Syntax](./rollovercollection.md)
*   [Property Value](./rollovercollection.md)
*   [Examples](./rollovercollection.md)