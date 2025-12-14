**Path**: [Position](./position.md)

# Position

# Position

## [Definition](./position.md)

Represents position related information that pertains to an instance of a strategy.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tips:

*   For multi\-instrument scripts, please see **Positions** object which holds an array of all instrument positions managed by the strategy's account.
*   For a real\-world Account Position, please see **PositionAccount**.

## [Methods and Properties](./position.md)

Property

Description

**Account**

An **Account** object which corresponds to the position

**AveragePrice**

Gets the average entry price of the strategy position

**GetUnrealizedProfitLoss()**

Gets the unrealized PnL

**Instrument**

An **Instrument** value representing the instrument of an order

**MarketPosition**

Gets the current market position

*   Possible values:
    *   **MarketPosition.Flat**
    *   **MarketPosition.Long**
    *   **MarketPosition.Short**

**Quantity**

Gets the current position size

**ToString()**

A string representation of a position

## [Examples](./position.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the average entry price
     Print("The average entry price is " + Position.AveragePrice);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./position.md)
*   [Methods and Properties](./position.md)
*   [Examples](./position.md)