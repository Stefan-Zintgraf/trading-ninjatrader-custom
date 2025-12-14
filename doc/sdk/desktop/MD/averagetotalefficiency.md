**Path**: [TradesPerformance](./tradesperformance.md) > [AverageTotalEfficiency](./averagetotalefficiency.md)

# AverageTotalEfficiency

# AverageTotalEfficiency

## [Definition](./averagetotalefficiency.md)

Returns the average total efficiency.

## [Property Value](./averagetotalefficiency.md)

A **double** value that represents the average total efficiency.

## [Syntax](./averagetotalefficiency.md)

`TradesPerformance.AverageTotalEfficiency`

## [Examples](./averagetotalefficiency.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the average total efficiency
     Print("Average total efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageTotalEfficiency);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averagetotalefficiency.md)
*   [Property Value](./averagetotalefficiency.md)
*   [Syntax](./averagetotalefficiency.md)
*   [Examples](./averagetotalefficiency.md)