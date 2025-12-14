**Path**: [TradesPerformance](./tradesperformance.md) > [MaxConsecutiveLoser](./maxconsecutiveloser.md)

# MaxConsecutiveLoser

# MaxConsecutiveLoser

## [Definition](./maxconsecutiveloser.md)

Returns the maximum number of consecutive losers seen.

## [Property Value](./maxconsecutiveloser.md)

An **int** value that represents the maximum number of consecutive losers seen.

## [Syntax](./maxconsecutiveloser.md)

`<tradecollection>.TradesPerformance.MaxConsecutiveLoser`

## [Examples](./maxconsecutiveloser.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the max consecutive losers of all trades
    Print("Max # of consecutive losers is: " + SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveLoser);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./maxconsecutiveloser.md)
*   [Property Value](./maxconsecutiveloser.md)
*   [Syntax](./maxconsecutiveloser.md)
*   [Examples](./maxconsecutiveloser.md)