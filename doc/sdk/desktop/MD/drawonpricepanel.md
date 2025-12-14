**Path**: [AddPlot()](./addplot.md) > [DrawOnPricePanel](./drawonpricepanel.md)

# DrawOnPricePanel

# DrawOnPricePanel

## [Definition](./drawonpricepanel.md)

Determines the chart panel the draw objects renders

## [Property Value](./drawonpricepanel.md)

This property returns true if the indicator paints draw objects on the price panel; otherwise when false, draw objects are painted on the actual indicator panel itself. Default set to true.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults**. Dynamically using **DrawOnPricePanel** in an indicator outside of **State.SetDefaults** may show issues when working with that indicator through a hosting strategy via **AddChartIndicator()**.

## [Syntax](./drawonpricepanel.md)

`DrawOnPricePanel`

## [Examples](./drawonpricepanel.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
          DrawOnPricePanel = false; // Draw objects now paint on the indicator panel itself     
          AddPlot(Brushes.Orange, "SMA");
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./drawonpricepanel.md)
*   [Property Value](./drawonpricepanel.md)
*   [Syntax](./drawonpricepanel.md)
*   [Examples](./drawonpricepanel.md)