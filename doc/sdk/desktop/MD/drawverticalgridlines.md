**Path**: [AddPlot()](./addplot.md) > [DrawVerticalGridLines](./drawverticalgridlines.md)

# DrawVerticalGridLines

# DrawVerticalGridLines

## [Definition](./drawverticalgridlines.md)

Plots vertical grid lines on the indicator panel.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The indicator panel's parent chart has a similar option 'Grid line \- vertical' which if Visible property set to false, will override the indicator's local setting if true.

## [Property Value](./drawverticalgridlines.md)

This property returns true if vertical grid lines are plotted on the indicator panel; otherwise, false. Default set to true.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults or State.Configure.

## [Syntax](./drawverticalgridlines.md)

`DrawVerticalGridLines`

## [Examples](./drawverticalgridlines.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         DrawVerticalGridLines = false; // Vertical grid lines will not plot on the indicator panel     
         AddPlot(Brushes.Orange, "SMA");
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./drawverticalgridlines.md)
*   [Property Value](./drawverticalgridlines.md)
*   [Syntax](./drawverticalgridlines.md)
*   [Examples](./drawverticalgridlines.md)