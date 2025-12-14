**Path**: [TradesPerformance](./tradesperformance.md) > [Percent](./percent.md)

# Percent

# Percent

## [Definition](./percent.md)

Returns a **TradesPerformanceValues** object in percent.

## [Property Value](./percent.md)

A **TradesPerformanceValues** object that is represented in percent.

## [Syntax](./percent.md)

`<tradecollection>.TradesPerformance.Percent`

## [Examples](./percent.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the avg. profit of all trades in percent
     Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Percent.AverageProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./percent.md)
*   [Property Value](./percent.md)
*   [Syntax](./percent.md)
*   [Examples](./percent.md)