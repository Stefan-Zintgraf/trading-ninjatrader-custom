**Path**: [ChartScale](./chartscale.md) > [GetYByValue()](./getybyvalue.md)

# GetYByValue()

# GetYByValue()

## [Definition](./getybyvalue.md)

Returns the chart's y\-pixel coordinate on the chart determined by a series value represented on the chart scale.

## [Method Return Value](./getybyvalue.md)

An **int** value representing a y pixel coordinate on the chart scale.

## [Syntax](./getybyvalue.md)

`<chartscale>.GetYByValue(double val)`

## [Method Parameters](./getybyvalue.md)

**val**

A **double** value which usually represents a price or indicator value

## [Examples](./getybyvalue.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // gets the pixel coordinate of the price value passed to the method
   int     yByValue = chartScale.GetYByValue(Bars.GetClose(Bars.Count - 1));

   Print("yByValue: " + yByValue); // 207
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, we pass the last bar close as the value (example logic avoids using a bars ago index, see also [OnRender()](./onrender.md) note #5), which in return tells us the last price displayed on the chart is at a y location of 207 pixels.

![getybyvalue](https://cdn.sanity.io/images/1hlwceal/production/288026b3a2e03e8229134b03ffccf26f243441eb-535x433.png)

#### ON THIS PAGE

*   [Definition](./getybyvalue.md)
*   [Method Return Value](./getybyvalue.md)
*   [Syntax](./getybyvalue.md)
*   [Method Parameters](./getybyvalue.md)
*   [Examples](./getybyvalue.md)