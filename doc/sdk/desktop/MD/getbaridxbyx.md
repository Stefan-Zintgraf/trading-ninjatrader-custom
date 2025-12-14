**Path**: [ChartBars](./chartbars.md) > [GetBarIdxByX()](./getbaridxbyx.md)

# GetBarIdxByX()

# GetBarIdxByX()

## [Definition](./getbaridxbyx.md)

Returns the **ChartBars** index value at a specified x\-coordinate relative to the ChartControl.

## [Method Return Value](./getbaridxbyx.md)

An **int** value representing the bar index.

## [Syntax](./getbaridxbyx.md)

`ChartBars.GetBarIdxByX(ChartControl chartControl, int x)`

## [Method Parameters](./getbaridxbyx.md)

**chartControl**

The **ChartControl** object used to determine the chart's time axis

**x**

The x\-coordinate used to find a bar index value

## [Examples](./getbaridxbyx.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // get the users mouse down point and convert to device pixels for DPI accuracy
   int mousePoint = chartControl.MouseDownPoint.X.ConvertToHorizontalPixels(chartControl.PresentationSource);
   
   // convert mouse point to bar index
   int barIdx = ChartBars.GetBarIdxByX(chartControl, mousePoint);
   
   Print("User clicked on Bar #" + barIdx);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getbaridxbyx.md)
*   [Method Return Value](./getbaridxbyx.md)
*   [Syntax](./getbaridxbyx.md)
*   [Method Parameters](./getbaridxbyx.md)
*   [Examples](./getbaridxbyx.md)