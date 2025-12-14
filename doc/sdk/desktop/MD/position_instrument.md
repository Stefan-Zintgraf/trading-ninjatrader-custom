**Path**: [Position](./position.md) > [Instrument](./position_instrument.md)

# Instrument

# Instrument

## [Definition](./position_instrument.md)

Gets the instrument of a strategy position.

## [Property Value](./position_instrument.md)

An **Instrument** representing the position's instrument.

## [Syntax](./position_instrument.md)

`Position.Instrument`

## [Examples](./position_instrument.md)

```csharp
protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition)
{
     // If the position is an AAPL position
     if (position.Instrument.MasterInstrument.Name == "AAPL")
   {
         //do something
   }
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./position_instrument.md)
*   [Property Value](./position_instrument.md)
*   [Syntax](./position_instrument.md)
*   [Examples](./position_instrument.md)