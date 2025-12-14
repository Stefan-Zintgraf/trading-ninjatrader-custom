**Path**: [TradesPerformance](./tradesperformance.md) > [TotalQuantity](./totalquantity.md)

# TotalQuantity

# TotalQuantity

## [Definition](./totalquantity.md)

Returns the total quantity.

## [Property Value](./totalquantity.md)

A **double** value that represents the total quantity.

## [Syntax](./totalquantity.md)

`<tradecollection>.TradesPerformance.TotalQuantity`

## [Examples](./totalquantity.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the total quantity of all trades
    Print("Total quantity is: " + SystemPerformance.AllTrades.TradesPerformance.TotalQuantity);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./totalquantity.md)
*   [Property Value](./totalquantity.md)
*   [Syntax](./totalquantity.md)
*   [Examples](./totalquantity.md)