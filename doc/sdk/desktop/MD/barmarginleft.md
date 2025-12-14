**Path**: [ChartControl](./chartcontrol.md) > [BarMarginLeft](./barmarginleft.md)

# BarMarginLeft

# BarMarginLeft

## [Definition](./barmarginleft.md)

A hard\-coded minimum bar margin value, set to 8 pixels, which can be used as a base value when creating custom Chart Styles.

## [Property Value](./barmarginleft.md)

A value representing the minimum margin applied to the left edge of bars. This value is hard\-coded to 8 pixels, and it can be used as a base value when setting the bar margin in custom [Chart Styles](./chart_style.md).

## [Syntax](./barmarginleft.md)

`ChartControl.BarMarginLeft`

## [Example](./barmarginleft.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
     // Print the number of pixels maintained as a margin to the left of bars
     double barMargin = chartControl.BarMarginLeft;
     Print(barMargin);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, BarMarginLeft reveals that the minimum margin maintained to the left of each bar is 8 pixels on this chart.

![ChartControl_BarMarginLeft](https://cdn.sanity.io/images/1hlwceal/production/77ecef5b0e0f6e776b96dd7eb1a8914ee55543bf-534x429.png)

#### ON THIS PAGE

*   [Definition](./barmarginleft.md)
*   [Property Value](./barmarginleft.md)
*   [Syntax](./barmarginleft.md)
*   [Example](./barmarginleft.md)