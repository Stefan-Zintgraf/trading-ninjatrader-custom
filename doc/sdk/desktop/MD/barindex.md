**Path**: [ChartAnchor](./chartanchor.md) > [SlotIndex](./barindex.md)

# SlotIndex

# SlotIndex

## [Definition](./barindex.md)

Indicates the nearest bar slot value where anchor is drawn on a chart. In a single series chart there will always be equal number of slots and bars, however for multi\-series charts there may be additional slots compared to the bar series your drawing tool resides.

## [Property Value](./barindex.md)

A **double** value representing the current bar.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The bar index value is represented as a double as it is possible (and likely) that a given chart anchor is drawn between bars (i.e., if a user draws the tool with snap mode disabled)

## [Syntax](./barindex.md)

`ChartAnchor.SlotIndex`

## [Examples](./barindex.md)

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
   Print(MyAnchor.SlotIndex); // prints the nearest current bar value
   //4502.02734375
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barindex.md)
*   [Property Value](./barindex.md)
*   [Syntax](./barindex.md)
*   [Examples](./barindex.md)