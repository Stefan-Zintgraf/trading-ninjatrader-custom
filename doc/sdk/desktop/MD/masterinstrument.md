**Path**: [MasterInstrument](./masterinstrument.md)

# MasterInstrument

# MasterInstrument

## [Definition](./masterinstrument.md)

An instrument's configuration settings. These are settings and properties which are defined in the **Instrument** window.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: The properties in this class should NOT be accessed within the **OnStateChange()** method before the State has reached State.DataLoaded.

## [Methods and Properties](./masterinstrument.md)

Method/Property

Description

[Compare()](./compare.md)

Returns An **int** value compares two price values with respect to the Instrument tick size

[Currency](./currency.md)

The currency that the instrument traded in

[Description](./description.md)

A written representation of a given instrument

[Dividends](./dividends.md)

A collection of dividends for stock instruments

[Exchanges](./exchanges.md)

A collection of exchanges configured for an instrument

[FormatPrice()](./formatprice.md)

Returns a string representing the price formatted to the nearest tick size

[InstrumentType](./instrumenttype.md)

The type of instrument

[MergePolicy](./mergepolicy.md)

The Merge Policy that is configured for the current master instrument.

[Name](./masterinstrument_name.md)

The name of the instrument.

[GetNextExpiry()](./getnextexpiry.md)

Returns a DateTime structure representing the next futures expiry for a given date

[PointValue](./pointvalue.md)

Currency value of 1 full point of movement

[RolloverCollection](./rollovercollection.md)

A collection of expiration dates and offsets for futures instruments

[RoundToTickSize()](./roundtoticksize.md)

Rounds the value up to the nearest valid value

[RoundDownToTickSize()](./rounddowntoticksize.md)

Rounds the value down to the nearest valid value

[Splits](./splits.md)

A collection of splits for stock instruments

[TickSize](./ticksize.md)

The smallest movement in price configured

[Url](./url.md)

A web url where contract details have been collected

#### ON THIS PAGE

*   [Definition](./masterinstrument.md)
*   [Methods and Properties](./masterinstrument.md)