**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [AverageMfe](./averagemfe.md)

# AverageMfe

# AverageMfe

## [Definition](./averagemfe.md)

Returns the average MFE (max favorable excursion) of the collection.

## [Property Value](./averagemfe.md)

A **double** value that represents the average MFE of the collection.

## [Syntax](./averagemfe.md)

`TradeCollection.TradesPerformance.TradesPerformanceValues.AverageMfe`

## [Examples](./averagemfe.md)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The following example prints out the average MFE of all trades in currency.

```csharp
protected override void OnBarUpdate()
{
     // Print out the average MFE of all trades in currency
     Print("Average MFE of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageMfe);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averagemfe.md)
*   [Property Value](./averagemfe.md)
*   [Syntax](./averagemfe.md)
*   [Examples](./averagemfe.md)