**Path**: [ChartPanel](./chartpanel.md) > [MaxValue](./maxvalue_chartpanel.md)

# MaxValue

# MaxValue

## [Definition](./maxvalue_chartpanel.md)

Indicates the maximum Y value of objects within the chart panel, based on the current y\-axis scale. The scale of the y\-axis is dependent upon the values of objects in the panel which have Auto Scale enabled.

## [Property Value](./maxvalue_chartpanel.md)

A **double** representing the maximum Y value in the panel's vertical scale

## [Syntax](./maxvalue_chartpanel.md)

`ChartPanel.MaxValue`

## [Examples](./maxvalue_chartpanel.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   base.OnRender(chartControl, chartScale);
 
   // Print the minimum and maximum Y values for objects in the panel
   Print(String.Format("Min value: {0}, Max value: {1}", ChartPanel.MinValue, ChartPanel.MaxValue));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./maxvalue_chartpanel.md)
*   [Property Value](./maxvalue_chartpanel.md)
*   [Syntax](./maxvalue_chartpanel.md)
*   [Examples](./maxvalue_chartpanel.md)