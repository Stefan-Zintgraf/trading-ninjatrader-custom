**Path**: [Instrument](./instrument.md) > [GetInstrument()](./getinstrument.md)

# GetInstrument()

# GetInstrument()

## [Definition](./getinstrument.md)

Returns an **Instrument** object by the master instrument name configured in the database.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method does NOT add additional data for real\-time or historical processing. For adding additional data to your script, please see the **AddDataSeries()** method.

## [Method Return Value](./getinstrument.md)

An **Instrument** object

## [Syntax](./getinstrument.md)

`Instrument.GetInstrument(string instrumentName)`

## [Parameters](./getinstrument.md)

**instrumentName**

A **string** value representing a name of an instrument

## [Examples](./getinstrument.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.Historical)
    {
        Instrument myInstrument = Instrument.GetInstrument("AAPL");

        Print("AAPL's tick size is " + myInstrument.MasterInstrument.TickSize.ToString());
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getinstrument.md)
*   [Method Return Value](./getinstrument.md)
*   [Syntax](./getinstrument.md)
*   [Parameters](./getinstrument.md)
*   [Examples](./getinstrument.md)