**Path**: [MasterInstrument](./masterinstrument.md) > [Url](./url.md)

# Url

# Url

## [Definition](./url.md)

Indicates the Url configured for the [Master Instrument properties](https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English.html?editing_instruments.htm).

## [Property Value](./url.md)

A **string** value representing the Url that is configured for the current master instrument.

## [Syntax](./url.md)

`Bars.Instrument.MasterInstrument.Url`

## [Examples](./url.md)

```csharp
protected override void OnBarUpdate()

 {

         // Displays the master instrument's URL at the bottom right of the chart

         Draw.TextFixed(this, "tag1", "Instruments URL is " + Bars.Instrument.MasterInstrument.Url, TextPosition.BottomRight);

 }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./url.md)
*   [Property Value](./url.md)
*   [Syntax](./url.md)
*   [Examples](./url.md)