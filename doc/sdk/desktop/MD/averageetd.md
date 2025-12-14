**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [AverageEtd](./averageetd.md)

# AverageEtd

# AverageEtd

## [Definition](./averageetd.md)

Returns the average ETD (end trade draw down) of the collection.

## [Property Value](./averageetd.md)

A **double** value that represents the average ETD of the collection.

## [Syntax](./averageetd.md)

`TradesCollection.TradesPerformance.TradesPerformanceValues.AverageEtd`

## [Examples](./averageetd.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the average ETD of all trades in currency
     Print("Average ETD of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageEtd);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averageetd.md)
*   [Property Value](./averageetd.md)
*   [Syntax](./averageetd.md)
*   [Examples](./averageetd.md)