**Path**: [ChartScale](./chartscale.md) > [MaxMinusMin](./maxminusmin.md)

# MaxMinusMin

# MaxMinusMin

## [Definition](./maxminusmin.md)

The difference between the chart scale's **MaxValue** and **MinValue** represented as a y value.

## [Property Value](./maxminusmin.md)

A **double** value representing the difference in scale as a y value.

## [Syntax](./maxminusmin.md)

<chartscale\`>.MaxMinusMin

## [Examples](./maxminusmin.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // the difference between the scales maximum and minimum value
   double   maxMinusMin = chartScale.MaxMinusMin;

   Print("maxMinusMin: " + maxMinusMin); // maxMinusMin: 3.92
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, the highest calculated value on the chart scale is 2106.21, with the lowest value being 2102.29; the MaxMinusMin property therefore provides us calculated value of 3.92.

![MaxMinusMin](https://cdn.sanity.io/images/1hlwceal/production/11c7c826e3f844bd3cc212d0ba3aa99b1f288ac2-535x433.png)

#### ON THIS PAGE

*   [Definition](./maxminusmin.md)
*   [Property Value](./maxminusmin.md)
*   [Syntax](./maxminusmin.md)
*   [Examples](./maxminusmin.md)