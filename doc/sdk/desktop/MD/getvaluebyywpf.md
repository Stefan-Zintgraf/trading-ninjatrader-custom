**Path**: [ChartScale](./chartscale.md) > [GetValueByYWpf()](./getvaluebyywpf.md)

# GetValueByYWpf()

# GetValueByYWpf()

## [Definition](./getvaluebyywpf.md)

Returns the series value on the chart scale determined by a WPF coordinate on the chart.

## [Method Return Value](./getvaluebyywpf.md)

A **double** value representing a series value on the chart scale. This is normally a price value, but can represent indicator plot values as well.

## [Syntax](./getvaluebyywpf.md)

`<chartscale>.GetValueByYWpf(double y)`

## [Method Parameters](./getvaluebyywpf.md)

**y**

A **double** value representing a WPF coordinate on the chart scale

## [Examples](./getvaluebyywpf.md)

```csharp

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // store the y location the user clicked
   double   wpfY = chartControl.MouseDownPoint.Y;

   // gets price value of the WPF coordinate passed to the method
   double   valueByYWpf = chartScale.GetValueByYWpf(wpfY);

   Print("valueByYWpf: " + valueByYWpf); //2105.49995215
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, we used the Chart Control property **MouseDownPoint** as the "wpfy" variable, which in return tells us the user clicked on a Y value of 2105.499 on the chart scale.

![getvaluebyywpf](https://cdn.sanity.io/images/1hlwceal/production/8c8cbcda1b4bee59b3e25c17310507dd2151360d-535x433.png)

#### ON THIS PAGE

*   [Definition](./getvaluebyywpf.md)
*   [Method Return Value](./getvaluebyywpf.md)
*   [Syntax](./getvaluebyywpf.md)
*   [Method Parameters](./getvaluebyywpf.md)
*   [Examples](./getvaluebyywpf.md)