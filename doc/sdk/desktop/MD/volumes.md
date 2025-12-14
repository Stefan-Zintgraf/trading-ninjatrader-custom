**Path**: [VolumeSeries<double>](./volumeseries.md) > [Volumes](./volumes.md)

# Volumes

# Volumes

## [Definition](./volumes.md)

Holds an array of **ISeries`<double>`** objects holding historical bar volumes. An **ISeries`<double>`** object is added to this array when calling the [AddDataSeries()](./adddataseries.md) method. Its purpose is to provide access to the volumes of all Bars objects in a multi\-instrument or multi\-time frame script.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For working with [Cryptocurrency instruments](./instrumenttype.md) which report volume fractional, please use the [VOL()](./volume.md) indicator series, or store the volume for your script in a custom variable and convert alongside our [VOL()](./volume.md) indicator `Instrument.MasterInstrument.InstrumentType == InstrumentType.CryptoCurrency ? Core.Globals.ToCryptocurrencyVolume((long)Volume[0]) : Volume[0]`).

## [Property Value](./volumes.md)

An array of **ISeries`<double>`** objects.

## [Syntax](./volumes.md)

`Volumes[int barSeriesIndex][int barsAgo]`

## [Examples](./volumes.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.Configure)
     {
         // Adds a 5-minute Bars object to the strategy and is automatically assigned
         // a Bars object index of 1 since the primary data the strategy is run against
         // set by the UI takes the index of 0.
         AddDataSeries("AAPL", BarsPeriodType.Minute, 5);
     }
} 

protected override void OnBarUpdate()
{ 
     // Compares the primary bar's volume to the 5-minute bar's volume
     if (Volumes[0][0] > Volumes[1][0])
         Print("The primary bar's volume is greater");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./volumes.md)
*   [Property Value](./volumes.md)
*   [Syntax](./volumes.md)
*   [Examples](./volumes.md)