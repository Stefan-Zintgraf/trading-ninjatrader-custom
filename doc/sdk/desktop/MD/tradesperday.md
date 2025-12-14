**Path**: [TradesPerformance](./tradesperformance.md) > [TradesPerDay](./tradesperday.md)

# TradesPerDay

# TradesPerDay

## [Definition](./tradesperday.md)

Returns the average number of trades per day.

## [Property Value](./tradesperday.md)

An **int** value that represents the average number of trades per day.

## [Syntax](./tradesperday.md)

`<tradecollection>.TradesPerformance.TradesPerDay`

## [Examples](./tradesperday.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the average number of trades per day of all trades
    Print("Average # of trades per day is: " + SystemPerformance.AllTrades.TradesPerformance.TradesPerDay);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./tradesperday.md)
*   [Property Value](./tradesperday.md)
*   [Syntax](./tradesperday.md)
*   [Examples](./tradesperday.md)