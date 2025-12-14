**Path**: [ChartPanel](./chartpanel.md) > [IsYAxisDisplayedLeft](./chartpanel_isyaxisdisplayedleft.md)

# IsYAxisDisplayedLeft

# IsYAxisDisplayedLeft

## [Definition](./chartpanel_isyaxisdisplayedleft.md)

Indicates the y\-axis is visible on the left side of the chart panel.

## [Property Value](./chartpanel_isyaxisdisplayedleft.md)

A bool indicating the y\-axis is visible to the left

## [Syntax](./chartpanel_isyaxisdisplayedleft.md)

`ChartPanel.IsYAxisDisplayedLeft`

## [Examples](./chartpanel_isyaxisdisplayedleft.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   base.OnRender(chartControl, chartScale);

   // Print a message if the y-axis is visible on the left
   if (ChartPanel.IsYAxisDisplayedLeft)
       Print("The y-axis is visible on the left");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, **IsYAxisDisplayedLeft** confirms that the y\-axis displays to the left. In this image, the property would be set to true when applied to either chart panel.

![ChartPanel_IsYAxisDisplayedLeft](https://cdn.sanity.io/images/1hlwceal/production/b6f7a9d5e000f73c1475c0972aaf49a2bcf74c13-534x433.png)

#### ON THIS PAGE

*   [Definition](./chartpanel_isyaxisdisplayedleft.md)
*   [Property Value](./chartpanel_isyaxisdisplayedleft.md)
*   [Syntax](./chartpanel_isyaxisdisplayedleft.md)
*   [Examples](./chartpanel_isyaxisdisplayedleft.md)