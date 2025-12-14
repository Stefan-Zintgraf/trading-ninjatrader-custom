**Path**: [PositionAccount](./positionaccount.md) > [Instrument](./positionaccount_instrument.md)

# Instrument

# Instrument

## [Definition](./positionaccount_instrument.md)

Gets the instrument of an account position.

## [Property Value](./positionaccount_instrument.md)

An **Instrument** representing the account's instrument position.

## [Syntax](./positionaccount_instrument.md)

`PositionAccount.Instrument`

## [Examples](./positionaccount_instrument.md)

```csharp

protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition)
{
     // If the position is an AAPL position
     if (PositionAccount.Instrument.MasterInstrument.Name == "AAPL")
   {
         //do something
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./positionaccount_instrument.md)
*   [Property Value](./positionaccount_instrument.md)
*   [Syntax](./positionaccount_instrument.md)
*   [Examples](./positionaccount_instrument.md)