**Path**: [MasterInstrument](./masterinstrument.md) > [PointValue](./pointvalue.md)

# PointValue

# PointValue

## [Definition](./pointvalue.md)

Indicates the currency value of 1 full point of movement. For example, 1 point in the **S&P 500 Emini** futures contract (ES) is $50 USD which is equal to $12.50 USD per tick.

## [Property Value](./pointvalue.md)

A **double** value representing the currency value of 1 point of movement.

## [Syntax](./pointvalue.md)

`Instrument.MasterInstrument.PointValue`

## [Examples](./pointvalue.md)

```csharp
// protected override void OnBarUpdate()
{
    // Displays the master instrument's point value at the bottom right of the chart
    Draw.TextFixed(this, "Point value: ", Bars.Instrument.MasterInstrument.PointValue.ToString(), TextPosition.BottomRight);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Additional Access Information](./pointvalue.md)

This property can be accessed without a null reference check in the **OnBarUpdate()** event handler. When the **OnBarUpdate()** event is triggered, there will always be an **Instrument** object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (**Instrument** != null)

#### ON THIS PAGE

*   [Definition](./pointvalue.md)
*   [Property Value](./pointvalue.md)
*   [Syntax](./pointvalue.md)
*   [Examples](./pointvalue.md)
*   [Additional Access Information](./pointvalue.md)