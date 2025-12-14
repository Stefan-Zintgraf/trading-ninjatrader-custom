**Path**: [ChartControl](./chartcontrol.md) > [IsYAxisDisplayedRight](./chartcontrol_isyaxisdisplayedright.md)

# IsYAxisDisplayedRight

# IsYAxisDisplayedRight

## [Definition](./chartcontrol_isyaxisdisplayedright.md)

Indicates the y\-axis displays (in any chart panel) to the right side of the chart.

## [Property Value](./chartcontrol_isyaxisdisplayedright.md)

A boolean value. When **True**, indicates that the y\-axis displays to the right of the chart canvas; otherwise **False**.

## [Syntax](./chartcontrol_isyaxisdisplayedright.md)

`<chartcontrol>.IsYAxisDisplayedRight`

## [Examples](./chartcontrol_isyaxisdisplayedright.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print the value of IsYAxisDisplayedRight
   Print("Y-Axis visible to the right of the chart canvas? " + chartControl.IsYAxisDisplayedRight);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, **IsYAxisDisplayedRight** confirms that the y\-axis is not displayed to the right of the chart canvas.

![ChartControl_IsYAxisDisplayedRight](https://cdn.sanity.io/images/1hlwceal/production/dcbfbe76e74b6dae7aca3c477875e914d04a5dfa-575x429.png)

#### ON THIS PAGE

*   [Definition](./chartcontrol_isyaxisdisplayedright.md)
*   [Property Value](./chartcontrol_isyaxisdisplayedright.md)
*   [Syntax](./chartcontrol_isyaxisdisplayedright.md)
*   [Examples](./chartcontrol_isyaxisdisplayedright.md)