**Path**: [ChartBars](./chartbars.md) > [ToIndex](./toindex.md)

# ToIndex

# ToIndex

## [Definition](./toindex.md)

An index value representing the last bar rendered on the chart. See also [FromIndex](./fromindex.md).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This value is NOT the last value that exists on the **ChartBars**, but rather the last bar index that is within the viewable range of the chart canvas area. This value changes as the user interacts with the **ChartControl** time\-scale (x\-axis).

## [Property Value](./toindex.md)

An int representing the last bar index painted on the chart.

## [Syntax](./toindex.md)

`ChartBars.ToIndex`

## [Examples](./toindex.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   if (ChartBars != null)
   {
     // loop through all of the viewable range of the chart
     for (int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)
     {
         // print the High value for each index within the viewable range
         Print(High.GetValueAt(barIndex));
     }
   }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./toindex.md)
*   [Property Value](./toindex.md)
*   [Syntax](./toindex.md)
*   [Examples](./toindex.md)