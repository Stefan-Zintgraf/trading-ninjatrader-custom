**Path**: [ChartBars](./chartbars.md) > [FromIndex](./fromindex.md)

# FromIndex

# FromIndex

## [Definition](./fromindex.md)

An index value representing the first bar rendered on the chart. See also **ToIndex**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This value is NOT the first value that exists on the **ChartBars**, but rather the first bar index that is within the viewable range of the chart canvas area. This value changes as the user interacts with the **ChartControl** time\-scale (x\-axis).

## [Property Value](./fromindex.md)

An int representing the first bar index painted on the chart.

## [Syntax](./fromindex.md)

`ChartBars.FromIndex`

## [Examples](./fromindex.md)

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
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./fromindex.md)
*   [Property Value](./fromindex.md)
*   [Syntax](./fromindex.md)
*   [Examples](./fromindex.md)