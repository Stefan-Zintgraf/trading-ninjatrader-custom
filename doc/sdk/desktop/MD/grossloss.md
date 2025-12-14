**Path**: [TradesPerformance](./tradesperformance.md) > [GrossLoss](./grossloss.md)

# GrossLoss

# GrossLoss

## [Definition](./grossloss.md)

Returns the gross loss.

## [Property Value](./grossloss.md)

A **double** value that represents the gross loss.

## [Syntax](./grossloss.md)

`<tradecollection>.TradesPerformance.GrossLoss`

## [Examples](./grossloss.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the gross loss of all trades
     Print("Gross loss is: " + SystemPerformance.AllTrades.TradesPerformance.GrossLoss);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./grossloss.md)
*   [Property Value](./grossloss.md)
*   [Syntax](./grossloss.md)
*   [Examples](./grossloss.md)