**Path**: [ChartPanel](./chartpanel.md) > [MinValue](./minvalue_chartpanel.md)

# MinValue

# MinValue

## [Definition](./minvalue_chartpanel.md)

Indicates the minimum Y value of objects within the chart panel, based on the current y\-axis scale. The scale of the y\-axis is dependent upon the values of objects in the panel which have Auto Scale enabled.

## [Property Value](./minvalue_chartpanel.md)

A **double** representing the minimum Y value in the panel's vertical scale

## [Syntax](./minvalue_chartpanel.md)

`ChartPanel.MinValue`

## [Examples](./minvalue_chartpanel.md)

```csharp

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)**
{
   base.OnRender(chartControl, chartScale);

   // Print the minimum and maximum Y values for objects in the panel
   Print(String.Format("Min value: {0}, Max value: {1}", **ChartPanel.MinValue**, **ChartPanel.MaxValue**));
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./minvalue_chartpanel.md)
*   [Property Value](./minvalue_chartpanel.md)
*   [Syntax](./minvalue_chartpanel.md)
*   [Examples](./minvalue_chartpanel.md)