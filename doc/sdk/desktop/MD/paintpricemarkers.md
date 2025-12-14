**Path**: [AddPlot()](./addplot.md) > [PaintPriceMarkers](./paintpricemarkers.md)

# PaintPriceMarkers

# PaintPriceMarkers

## [Definition](./paintpricemarkers.md)

If true, any indicator plot values display price markers in the y\-axis.

## [Property Value](./paintpricemarkers.md)

This property returns true if the indicator plot values display in the y\-axis; otherwise, false. Default set to true.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./paintpricemarkers.md)

`PaintPriceMarkers`

## [Examples](./paintpricemarkers.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         PaintPriceMarkers = true; // Indicator plots values display in the y-axis
         AddPlot(Brushes.Orange, "SMA");
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./paintpricemarkers.md)
*   [Property Value](./paintpricemarkers.md)
*   [Syntax](./paintpricemarkers.md)
*   [Examples](./paintpricemarkers.md)