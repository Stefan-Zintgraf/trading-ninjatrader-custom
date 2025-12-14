**Path**: [ChartScale](./chartscale.md) > [IsOverlay](./isoverlay.md)

# IsOverlay

# IsOverlay

## [Definition](./isoverlay.md)

Determines if indicator plot(s) are drawn on the chart panel over top of price.  Setting this value to true will also allow an Indicator to be used as a [SuperDOM Indicator](https://ninjatrader.com/support/helpGuides/nt8/working_with_indicators_superdom.htm).

## [Property Value](./isoverlay.md)

This property returns true if any indicator plot(s) are drawn on the chart panel; otherwise, false. Default set to false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the [OnStateChange()](./onstatechange.md) method during State.SetDefaults

## [Syntax](./isoverlay.md)

`IsOverlay`

## [Examples](./isoverlay.md)

```csharp
protected override void OnStateChange() 
{ 
    if (State == State.SetDefaults) 
    { 
        IsOverlay = true; // Indicator plots are drawn on the chart panel on top of price     
        AddPlot(Brushes.Orange, "SMA"); 
    } 
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isoverlay.md)
*   [Property Value](./isoverlay.md)
*   [Syntax](./isoverlay.md)
*   [Examples](./isoverlay.md)