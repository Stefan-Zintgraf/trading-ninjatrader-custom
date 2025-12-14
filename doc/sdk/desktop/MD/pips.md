**Path**: [TradesPerformance](./tradesperformance.md) > [Pips](./pips.md)

# Pips

# Pips

## [Definition](./pips.md)

Returns a **TradesPerformanceValues** object in pips.

## [Property Value](./pips.md)

A **TradesPerformanceValues** object that is represented in pips.

## [Syntax](./pips.md)

`<tradecollection>.TradesPerformance.Pips`

## [Examples](./pips.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the avg. profit of all trades in pips
     Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Pips.AverageProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./pips.md)
*   [Property Value](./pips.md)
*   [Syntax](./pips.md)
*   [Examples](./pips.md)