**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [LargestWinner](./largestwinner.md)

# LargestWinner

# LargestWinner

## [Definition](./largestwinner.md)

Returns the largest win amount of the collection.

## [Property Value](./largestwinner.md)

A **double** value that represents the largest win amount of the collection.

## [Syntax](./largestwinner.md)

`<tradecollection>.TradesPerformance.<tradesperformancevalues>.LargestWinner`

## [Examples](./largestwinner.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the largest win of all trades in currency
     Print("Largest win of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.LargestWinner);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./largestwinner.md)
*   [Property Value](./largestwinner.md)
*   [Syntax](./largestwinner.md)
*   [Examples](./largestwinner.md)