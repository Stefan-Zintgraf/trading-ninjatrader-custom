**Path**: [TradesPerformance](./tradesperformance.md) > [Points](./points.md)

# Points

# Points

## [Definition](./points.md)

Returns a **TradesPerformanceValues** object in points.

## [Property Value](./points.md)

A **TradesPerformanceValues** object that is represented in points.

## [Syntax](./points.md)

`<tradecollection>.TradesPerformance.Points`

## [Examples](./points.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the avg. profit of all trades in points
     Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Points.AverageProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./points.md)
*   [Property Value](./points.md)
*   [Syntax](./points.md)
*   [Examples](./points.md)