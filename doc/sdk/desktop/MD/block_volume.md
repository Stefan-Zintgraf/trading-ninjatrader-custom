**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Block Volume](./block_volume.md)

# Block Volume

# Block Volume

## [Description](./block_volume.md)

Block volume detects block trades and display how many occurred per bar. This can be displayed either as trades or volume. Historical tick data is required to plot historically.

## [Syntax](./block_volume.md)

`BlockVolume(int blockSize, CountType countType)`

`BlockVolume(ISeries<double> input, int blockSize, CountType countType)`

## [Return Value](./block_volume.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./block_volume.md)

input

Indicator source data

blockSize

The minimum volume a trade must be to be considered a block trade

countType

The format to count the block trades. By number of block trades that occurred or total block trade volume

## [Examples](./block_volume.md)

```csharp
// A 1 tick data series must be added to OnStateChange() as this indicator runs off of tick data
else if (State == State.Configure)
{
   AddDataSeries(Data.BarsPeriodType.Tick, 1);
}
 
// Prints the current value of an 80 block trade size counted in volume for the Block Volume
if (BarsInProgress == 0)
{
double value = BlockVolume(80, CountType.Volume)[0];
Print("The current Block Volume value is " + value.ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./block_volume.md)
*   [Syntax](./block_volume.md)
*   [Return Value](./block_volume.md)
*   [Parameters](./block_volume.md)
*   [Examples](./block_volume.md)