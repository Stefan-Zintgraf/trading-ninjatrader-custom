**Path**: [Chart Style](./chart_style.md) > [OnRender()](./chartstyle_onrender.md)

# OnRender()

# OnRender()

## [Definition](./chartstyle_onrender.md)

An event driven method used to render content to a ChartStyle. The **OnRender()** method is called every time the chart values are updated. These updates are driven by incoming data to the chart bars or by a user manually interacting with the chart control or chart scale.

## [Method Return Value](./chartstyle_onrender.md)

This method does not return a value.

## [Syntax](./chartstyle_onrender.md)

You must override the method in your ChartStyle with the following syntax:

`protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars) { }`

## [Method Parameters](./chartstyle_onrender.md)

**chartControl**

A ChartControl representing the x\-axis

**chartScale**

A ChartScale representing the y\-axis

**chartBars**

A ChartBars representing the Bars series for the chart

## [Examples](./chartstyle_onrender.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)
{
    // Rendering logic for our chart style
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartstyle_onrender.md)
*   [Method Return Value](./chartstyle_onrender.md)
*   [Syntax](./chartstyle_onrender.md)
*   [Method Parameters](./chartstyle_onrender.md)
*   [Examples](./chartstyle_onrender.md)