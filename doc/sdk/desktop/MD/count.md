**Path**: [OnBarUpdate()](./onbarupdate.md) > [Count](./count.md)

# Count

# Count

## [Definition](./count.md)

The total number of bars or data points.

## [Property Value](./count.md)

An **int** value representing the total number of bars.

## [Syntax](./count.md)

`Count`

## [Examples](./count.md)

```csharp
//If there are less than 365 bars on the chart, text indicates how many bars are on the chart
if (Count < 365)
{
  Draw.TextFixed(this, "tag1", "There are " + Count + " bars on the chart", TextPosition.BottomRight);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

[CurrentBar](./currentbar.md) value is guaranteed to be <= Count \- 1. This is because of the NinjaTrader multi\-threaded architecture, the Count value can have additional bars as inflight ticks come in to the system.

#### ON THIS PAGE

*   [Definition](./count.md)
*   [Property Value](./count.md)
*   [Syntax](./count.md)
*   [Examples](./count.md)