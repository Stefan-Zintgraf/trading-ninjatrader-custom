**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [AverageMae](./averagemae.md)

# AverageMae

# AverageMae

## [Definition](./averagemae.md)

Returns the average MAE (max adverse excursion) of the collection.

## [Property Value](./averagemae.md)

A **double** value that represents the average MAE of the collection.

## [Syntax](./averagemae.md)

`tradecollection.TradesPerformance.tradesperformancevalues.AverageMae`

## [Examples](./averagemae.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the average MAE of all trades in currency
     Print("Average MAE of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageMae);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averagemae.md)
*   [Property Value](./averagemae.md)
*   [Syntax](./averagemae.md)
*   [Examples](./averagemae.md)