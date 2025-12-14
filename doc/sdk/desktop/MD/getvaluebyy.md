**Path**: [ChartScale](./chartscale.md) > [GetValueByY()](./getvaluebyy.md)

# GetValueByY()

# GetValueByY()

## [Definition](./getvaluebyy.md)

Returns the series value on the chart scale determined by a y pixel coordinate on the chart.

## [Method Return Value](./getvaluebyy.md)

A **double** value representing a series value on the chart scale. This is normally a price value, but can represent indicator plot values as well.

## [Syntax](./getvaluebyy.md)

`<chartscale>.GetValueByY(float y)`

## [Method Parameters](./getvaluebyy.md)

**y**

A float value representing a pixel coordinate on the chart scale

## [Examples](./getvaluebyy.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // the price value of the pixel coordinate passed in the method
   double valueByY =   chartScale.GetValueByY(1);

   Print("valueByY: " + valueByY); //2106.19693333
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, we pass a value of 1 for the y value, which tells us the pixel coordinate of 1 is located at a price of 2106.19 on the chart scale.

![getvaluebyY](https://cdn.sanity.io/images/1hlwceal/production/c6bfc1f09add776095242528ac133bb5de245be2-535x433.png)

#### ON THIS PAGE

*   [Definition](./getvaluebyy.md)
*   [Method Return Value](./getvaluebyy.md)
*   [Syntax](./getvaluebyy.md)
*   [Method Parameters](./getvaluebyy.md)
*   [Examples](./getvaluebyy.md)