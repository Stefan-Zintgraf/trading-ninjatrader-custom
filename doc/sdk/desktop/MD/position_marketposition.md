**Path**: [Position](./position.md) > [MarketPosition](./position_marketposition.md)

# MarketPosition

# MarketPosition

## [Definition](./position_marketposition.md)

Gets the strategy's current market position

## [Property Value](./position_marketposition.md)

*   **MarketPosition.Flat**
*   **MarketPosition.Long**
*   **MarketPosition.Short**

## [Syntax](./position_marketposition.md)

`Position.MarketPosition`

## [Examples](./position_marketposition.md)

```csharp
protected override void OnBarUpdate()
{
     // If not flat print our open PnL
     if (Position.MarketPosition != MarketPosition.Flat)
         Print("Open PnL: " + Position.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close[0]));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./position_marketposition.md)
*   [Property Value](./position_marketposition.md)
*   [Syntax](./position_marketposition.md)
*   [Examples](./position_marketposition.md)