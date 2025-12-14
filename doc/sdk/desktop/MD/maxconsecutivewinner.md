**Path**: [TradesPerformance](./tradesperformance.md) > [MaxConsecutiveWinner](./maxconsecutivewinner.md)

# MaxConsecutiveWinner

# MaxConsecutiveWinner

## [Definition](./maxconsecutivewinner.md)

Returns the maximum number of consecutive winners seen.

## [Property Value](./maxconsecutivewinner.md)

An **int** value that represents the maximum number of consecutive winners seen.

## [Syntax](./maxconsecutivewinner.md)

`<tradecollection>.TradesPerformance.MaxConsecutiveWinner`

## [Examples](./maxconsecutivewinner.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the max consecutive winners of all trades
     Print("Max # of consecutive winners is: " + SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveWinner);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./maxconsecutivewinner.md)
*   [Property Value](./maxconsecutivewinner.md)
*   [Syntax](./maxconsecutivewinner.md)
*   [Examples](./maxconsecutivewinner.md)