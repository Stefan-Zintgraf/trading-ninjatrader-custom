**Path**: [ChartControl](./chartcontrol.md) > [BarSpacingType](./barspacingtype.md)

# BarSpacingType

# BarSpacingType

## [Definition](./barspacingtype.md)

Indicates the type of bar spacing used for the primary [Bars](./bars.md) object on the chart.

## [Property Value](./barspacingtype.md)

An enum representing one of the values below:

EquidistantSingle

Indicates Equidistant Bar Spacing is used, and only one Bars object exists on the chart

EquidistantMulti

Indicates Equidistant Bar Spacing is used, and more than one Bars objects exist on the chart

TimeBased

Indicates Time\-Based bar spacing is used

## [Syntax](./barspacingtype.md)

`chartcontrol.BarSpacingType`

## [Example](./barspacingtype.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print the type of bar spacing used on the chart
   Print(chartControl.BarSpacingType);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, BarSpacingType confirms that there are multiple Bars objects configured on the chart, and that the chart is set to Equidistant Bar Spacing:

![ChartControl_BarSpacingType](https://cdn.sanity.io/images/1hlwceal/production/e0253c5162258c0e876185bb351fcf0e0dad7fcf-605x472.png)

#### ON THIS PAGE

*   [Definition](./barspacingtype.md)
*   [Property Value](./barspacingtype.md)
*   [Syntax](./barspacingtype.md)
*   [Example](./barspacingtype.md)