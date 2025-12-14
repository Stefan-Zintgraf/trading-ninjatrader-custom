**Path**: [Instrument](./instrument.md)

# Instrument

# Instrument

## [Definition](./instrument.md)

A tradable symbol. Represents an instance of a **Master Instrument**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Warning: The properties in this class should NOT be accessed within the **OnStateChange()** method before the State has reached State.DataLoaded.

## [Methods and Properties](./instrument.md)

Method/Property

Description

[Exchange](./exchange.md)

Exchange of the current instrument

[Expiry](./expiry.md)

Expiration date of the futures contract

[FullName](./fullname.md)

Full name of the instrument

[GetInstrument()](./getinstrument.md)

Returns an Instrument object by the master instrument name configured in the database.

[MasterInstrument](./masterinstrument.md)

An instrument's configuration settings. These are settings and properties which are defined in the **Instrument** window.

FundamentalData

Instrument thread specific **FundamentalData** events

MarketData

Instrument thread specific **MarketData** events

MarketDepth

Instrument thread specific **MarketDepth** events

Dispatcher

A Dispatcher used for subscribing to Instrument related events. See **Multi\-Threading Considerations**.

#### ON THIS PAGE

*   [Definition](./instrument.md)
*   [Methods and Properties](./instrument.md)