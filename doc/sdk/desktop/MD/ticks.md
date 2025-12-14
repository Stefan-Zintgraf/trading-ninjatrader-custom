**Path**: [TradesPerformance](./tradesperformance.md) > [Ticks](./ticks.md)

# Ticks

# Ticks

## [Definition](./ticks.md)

Returns a **TradesPerformanceValues** object in ticks.

## [Property Value](./ticks.md)

A **TradesPerformanceValues** object that is represented in ticks.

## [Syntax](./ticks.md)

`<tradecollection>.TradesPerformance.Ticks`

## [Examples](./ticks.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the avg. profit of all trades in ticks
     Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Ticks.AverageProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ticks.md)
*   [Property Value](./ticks.md)
*   [Syntax](./ticks.md)
*   [Examples](./ticks.md)