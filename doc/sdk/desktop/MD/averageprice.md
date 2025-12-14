**Path**: [Position](./position.md) > [AveragePrice](./averageprice.md)

# AveragePrice

# AveragePrice

## [Definition](./averageprice.md)

Gets the average price of a strategy position.

## [Property Value](./averageprice.md)

A **double** value representing the position's average price per unit.

## [Syntax](./averageprice.md)

`Position.AveragePrice`

## [Examples](./averageprice.md)

```csharp
protected override void OnBarUpdate()
{
     // Raise stop loss to breakeven when there is at least 10 ticks in profit
     if (Close[0] >= Position.AveragePrice + 10 * TickSize)
         ExitLongStopMarket(Position.Quantity, Position.AveragePrice);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averageprice.md)
*   [Property Value](./averageprice.md)
*   [Syntax](./averageprice.md)
*   [Examples](./averageprice.md)