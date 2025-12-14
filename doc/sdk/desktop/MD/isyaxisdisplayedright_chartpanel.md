**Path**: [ChartPanel](./chartpanel.md) > [IsYAxisDisplayedRight](./isyaxisdisplayedright_chartpanel.md)

# IsYAxisDisplayedRight

# IsYAxisDisplayedRight

## [Definition](./isyaxisdisplayedright_chartpanel.md)

Indicates the y\-axis is visible on the right side of the chart panel.

## [Property Value](./isyaxisdisplayedright_chartpanel.md)

A **bool** indicating the y\-axis is visible to the right

## [Syntax](./isyaxisdisplayedright_chartpanel.md)

`ChartPanel.IsYAxisDisplayedRight`

## [Examples](./isyaxisdisplayedright_chartpanel.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)

{

   base.OnRender(chartControl, chartScale);

   // Print a message if the y-axis is visible on the right

   if (ChartPanel.IsYAxisDisplayedRight)

       Print("The y-axis is visible on the right");

}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, **IsYAxisDisplayedRight** confirms that the y\-axis is not displayed on the right. The property would be set to false when applied in either chart panel in this instance.

![ChartPanel_IsYAxisDisplayedRight](https://cdn.sanity.io/images/1hlwceal/production/20d23d58fe540df5aeaf13c0934c42f93b186e86-534x433.png)

#### ON THIS PAGE

*   [Definition](./isyaxisdisplayedright_chartpanel.md)
*   [Property Value](./isyaxisdisplayedright_chartpanel.md)
*   [Syntax](./isyaxisdisplayedright_chartpanel.md)
*   [Examples](./isyaxisdisplayedright_chartpanel.md)