**Path**: [ChartControl](./chartcontrol.md) > [IsYAxisDisplayedOverlay](./isyaxisdisplayedoverlay.md)

# IsYAxisDisplayedOverlay

# IsYAxisDisplayedOverlay

## [Definition](./isyaxisdisplayedoverlay.md)

Indicates an object on the chart is using the Overlay scale justification.

## [Property Value](./isyaxisdisplayedoverlay.md)

A boolean value. When **True**, indicates that one or more objects on the chart are using the Overlay scale justification; otherwise **False**.

## [Syntax](./isyaxisdisplayedoverlay.md)

`<chartcontrol>.IsYAxisDisplayedOverlay`

## [Examples](./isyaxisdisplayedoverlay.md)

```csharp

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print the value of IsYAxisDisplayedOverlay
   Print("Is Overlay used? " + chartControl.IsYAxisDisplayedOverlay);
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, **IsYAxisDisplayedOverlay** confirms that an object on the chart, in this case an SMA indicator, is using the Overlay scale justification.

![ChartControl_IsXAxisDisplayedOverlay](https://cdn.sanity.io/images/1hlwceal/production/8681385f146613b3a73a4831e1808f14fc5d4b49-732x541.png)

#### ON THIS PAGE

*   [Definition](./isyaxisdisplayedoverlay.md)
*   [Property Value](./isyaxisdisplayedoverlay.md)
*   [Syntax](./isyaxisdisplayedoverlay.md)
*   [Examples](./isyaxisdisplayedoverlay.md)