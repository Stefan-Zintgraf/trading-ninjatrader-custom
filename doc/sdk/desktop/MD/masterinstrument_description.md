**Path**: [MasterInstrument](./masterinstrument.md) > [Description](./masterinstrument_description.md)

# Description

# Description

## [Definition](./masterinstrument_description.md)

Indicates the description configured for the **Master Instrument properties**.

## [Property Value](./masterinstrument_description.md)

A **string** value which is configured for the current master instrument.

## [Syntax](./masterinstrument_description.md)

`Bars.Instrument.MasterInstrument.Description`

## [Examples](./masterinstrument_description.md)

```csharp
protected override void OnBarUpdate()
{
    // Displays the master instrument's description at the bottom right of the chart
    Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.Description, TextPosition.BottomRight);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./masterinstrument_description.md)
*   [Property Value](./masterinstrument_description.md)
*   [Syntax](./masterinstrument_description.md)
*   [Examples](./masterinstrument_description.md)