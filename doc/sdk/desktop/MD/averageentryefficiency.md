**Path**: [TradesPerformance](./tradesperformance.md) > [AverageEntryEfficiency](./averageentryefficiency.md)

# AverageEntryEfficiency

# AverageEntryEfficiency

## [Definition](./averageentryefficiency.md)

Returns the average entry efficiency.

## [Property Value](./averageentryefficiency.md)

A **double** value that represents the average entry efficiency.

## [Syntax](./averageentryefficiency.md)

`TradesPerformance.AverageEntryEfficiency`

## [Examples](./averageentryefficiency.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the average entry efficiency
     Print("Average entry efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageEntryEfficiency);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averageentryefficiency.md)
*   [Property Value](./averageentryefficiency.md)
*   [Syntax](./averageentryefficiency.md)
*   [Examples](./averageentryefficiency.md)