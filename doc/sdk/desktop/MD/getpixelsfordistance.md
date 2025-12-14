**Path**: [ChartScale](./chartscale.md) > [GetPixelsForDistance()](./getpixelsfordistance.md)

# GetPixelsForDistance()

# GetPixelsForDistance()

## [Definition](./getpixelsfordistance.md)

Returns the number of device pixels between the value passed to the method representing a series point value on the chart scale.

## [Method Return Value](./getpixelsfordistance.md)

A float representing the number of pixels between a value.

## [Syntax](./getpixelsfordistance.md)

`<chartscale>.GetPixelsForDistance(double distance)`

## [Method Parameters](./getpixelsfordistance.md)

distance

A **double** value representing the distance in points to be measured

## [Examples](./getpixelsfordistance.md)

```csharp

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // the number of pixels between the point value passed as a distance to the method
   float pixelForDistance = chartScale.GetPixelsForDistance(0.25);

   Print("pixelForDistance: " + pixelForDistance); //20 pixels per every 1 tick on the chart scale

}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, we pass a value of 1 for the distance, which tells us there are 76 pixels for every 1 point on the ES 06\-15 chart scale.

![GetPixelsForDistance](https://cdn.sanity.io/images/1hlwceal/production/23f135c9e1f379b4fbe13ce31ed0089a3915309c-535x433.png)

#### ON THIS PAGE

*   [Definition](./getpixelsfordistance.md)
*   [Method Return Value](./getpixelsfordistance.md)
*   [Syntax](./getpixelsfordistance.md)
*   [Method Parameters](./getpixelsfordistance.md)
*   [Examples](./getpixelsfordistance.md)