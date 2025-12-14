**Path**: [TradesPerformance](./tradesperformance.md) > [LongestFlatPeriod](./longestflatperiod.md)

# LongestFlatPeriod

# LongestFlatPeriod

## [Definition](./longestflatperiod.md)

Returns the longest duration of being flat.

## [Property Value](./longestflatperiod.md)

A TimeSpan value that represents the longest duration of being flat.

## [Syntax](./longestflatperiod.md)

`<tradecollection>.TradesPerformance.LongestFlatPeriod`

## [Examples](./longestflatperiod.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the longest duration of being flat
     Print("Longest flat period: " + SystemPerformance.AllTrades.TradesPerformance.LongestFlatPeriod);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./longestflatperiod.md)
*   [Property Value](./longestflatperiod.md)
*   [Syntax](./longestflatperiod.md)
*   [Examples](./longestflatperiod.md)