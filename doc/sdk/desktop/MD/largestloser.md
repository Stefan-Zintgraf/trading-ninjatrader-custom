**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [LargestLoser](./largestloser.md)

# LargestLoser

# LargestLoser

## [Definition](./largestloser.md)

Returns the largest loss amount of the collection.

## [Property Value](./largestloser.md)

A **double** value that represents the largest loss amount of the collection.

## [Syntax](./largestloser.md)

`<tradecollection>.TradesPerformance.<tradesperformancevalues>.LargestLoser`

## [Examples](./largestloser.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the largest loss of all trades in currency
     Print("Largest loss of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.LargestLoser);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./largestloser.md)
*   [Property Value](./largestloser.md)
*   [Syntax](./largestloser.md)
*   [Examples](./largestloser.md)