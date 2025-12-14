**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [Drawdown](./drawdown.md)

# Drawdown

# Drawdown

## [Definition](./drawdown.md)

Returns the draw down of the trade collection.

## [Property Value](./drawdown.md)

A **double** value that represents the average ETD of the collection.

## [Syntax](./drawdown.md)

`<tradecollection>.TradesPerformance.<tradesperformancevalues>.Drawdown`

## [Examples](./drawdown.md)

```csharp
protected override void OnBarUpdate()
{
          // Print out the draw down of all trades in currency
     Print("Draw down of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Drawdown);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./drawdown.md)
*   [Property Value](./drawdown.md)
*   [Syntax](./drawdown.md)
*   [Examples](./drawdown.md)