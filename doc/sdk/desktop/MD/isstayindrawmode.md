**Path**: [ChartControl](./chartcontrol.md) > [IsStayInDrawMode](./isstayindrawmode.md)

# IsStayInDrawMode

# IsStayInDrawMode

## [Definition](./isstayindrawmode.md)

Indicates **Stay in Draw Mode** is currently enabled on the chart.

## [Property Value](./isstayindrawmode.md)

A bool value. When True, indicates that Stay in Draw Mode is enabled on the chart; otherwise False.

## [Syntax](./isstayindrawmode.md)

`<chartcontrol>.IsStayInDrawMode`

## [Examples](./isstayindrawmode.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print a message if Stay in Draw Mode is enabled
   if(chartControl.IsStayInDrawMode);
       Print("Stay in Draw Mode is currently enabled");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isstayindrawmode.md)
*   [Property Value](./isstayindrawmode.md)
*   [Syntax](./isstayindrawmode.md)
*   [Examples](./isstayindrawmode.md)