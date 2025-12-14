**Path**: [PositionAccount](./positionaccount.md) > [MarketPosition](./marketposition.md)

# MarketPosition

# MarketPosition

## [Definition](./marketposition.md)

Gets the account's current market position

## [Property Value](./marketposition.md)

*   **MarketPosition.Flat**
*   **MarketPosition.Long**
*   **MarketPosition.Short**

## [Syntax](./marketposition.md)

`PositionAccount.MarketPosition`

## [Examples](./marketposition.md)

```csharp
protected override void OnBarUpdate()
{ 
    // If not flat print our open PnL
    if (PositionAccount.MarketPosition != MarketPosition.Flat) 
        Print("Open PnL: " + PositionAccount.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close[0]));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./marketposition.md)
*   [Property Value](./marketposition.md)
*   [Syntax](./marketposition.md)
*   [Examples](./marketposition.md)