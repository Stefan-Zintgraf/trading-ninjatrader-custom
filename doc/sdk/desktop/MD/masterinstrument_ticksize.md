**Path**: [MasterInstrument](./masterinstrument.md) > [TickSize](./masterinstrument_ticksize.md)

# TickSize

# TickSize

## [Definition](./masterinstrument_ticksize.md)

Indicates the tick size configured for the **Master Instrument properties**.

## [Property Value](./masterinstrument_ticksize.md)

A **double** value representing the tick size configured for the current master instrument.

## [Syntax](./masterinstrument_ticksize.md)

`Bars.Instrument.MasterInstrument.TickSize`

## [Examples](./masterinstrument_ticksize.md)

```csharp
protected override void OnBarUpdate()
{
    // Displays the master instrument's tick size at the bottom right of the chart
    Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.TickSize.ToString(), TextPosition.BottomRight);

}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./masterinstrument_ticksize.md)
*   [Property Value](./masterinstrument_ticksize.md)
*   [Syntax](./masterinstrument_ticksize.md)
*   [Examples](./masterinstrument_ticksize.md)