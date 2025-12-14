**Path**: [TradesPerformance](./tradesperformance.md) > [AverageExitEfficiency](./averageexitefficiency.md)

# AverageExitEfficiency

# AverageExitEfficiency

## [Definition](./averageexitefficiency.md)

Returns the average exit efficiency.

## [Property Value](./averageexitefficiency.md)

A **double** value that represents the average exit efficiency.

## [Syntax](./averageexitefficiency.md)

`TradesPerformance.AverageExitEfficiency`

## [Examples](./averageexitefficiency.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the average exit efficiency
     Print("Average exit efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageExitEfficiency);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averageexitefficiency.md)
*   [Property Value](./averageexitefficiency.md)
*   [Syntax](./averageexitefficiency.md)
*   [Examples](./averageexitefficiency.md)