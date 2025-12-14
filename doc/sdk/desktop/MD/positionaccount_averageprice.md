**Path**: [PositionAccount](./positionaccount.md) > [AveragePrice](./positionaccount_averageprice.md)

# AveragePrice

# AveragePrice

## [Definition](./positionaccount_averageprice.md)

Gets the average price of an account position.

## [Property Value](./positionaccount_averageprice.md)

A **double** value representing the account position's average price per unit.

## [Syntax](./positionaccount_averageprice.md)

`PositionAccount.AveragePrice`

## [Examples](./positionaccount_averageprice.md)

```csharp
protected override void OnBarUpdate()
// Raise stop loss to breakeven when there is at least 10 ticks in profit
if (Close[0] >= PositionAccount.AveragePrice + 10 * TickSize)
    ExitLongStopMarket(PositionAccount.Quantity, PositionAccount.AveragePrice);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./positionaccount_averageprice.md)
*   [Property Value](./positionaccount_averageprice.md)
*   [Syntax](./positionaccount_averageprice.md)
*   [Examples](./positionaccount_averageprice.md)