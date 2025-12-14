**Path**: [ChartScale](./chartscale.md) > [MaxValue](./chartscale_maxvalue.md)

# MaxValue

# MaxValue

## [Definition](./chartscale_maxvalue.md)

The highest displayed value on the chart scale.

## [Property Value](./chartscale_maxvalue.md)

A **double** value representing highest value on the chart scale as a y value.

## [Syntax](./chartscale_maxvalue.md)

`<chartscale>.MaxValue`

## [Examples](./chartscale_maxvalue.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // the maximum value of the chart scale
   double maxValue   = chartScale.MaxValue;

   Print("maxValue: " + maxValue);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, the highest value displayed as text on the y\-axis reads 2106.00, however as you can see, there are a few pixels on the chart scale above this tick. The absolute rendered MaxValue on the chart scale is calculated as 2106.21.

![MaxValue](https://cdn.sanity.io/images/1hlwceal/production/f8a6355f41a7e05792e96c72113fa5288d793fed-535x433.png)

#### ON THIS PAGE

*   [Definition](./chartscale_maxvalue.md)
*   [Property Value](./chartscale_maxvalue.md)
*   [Syntax](./chartscale_maxvalue.md)
*   [Examples](./chartscale_maxvalue.md)