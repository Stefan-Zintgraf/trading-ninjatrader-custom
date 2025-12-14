**Path**: [ChartControl](./chartcontrol.md) > [IsScrollArrowVisible](./isscrollarrowvisible.md)

# IsScrollArrowVisible

# IsScrollArrowVisible

## [Definition](./isscrollarrowvisible.md)

Indicates the time\-axis scroll arrow is visible in the top\-right corner of the chart.

## [Property Value](./isscrollarrowvisible.md)

A bool value. When **True**, indicates that the scroll arrow is visible on the chart; otherwise **False**.

## [Syntax](./isscrollarrowvisible.md)

`<chartcontrol>.IsScrollArrowVisible`

## [Examples](./isscrollarrowvisible.md)

```csharp

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print a message if the scroll arrow is visible on the chart
   if(chartControl.IsScrollArrowVisible);
       Print("The chart is currently not set to auto-scroll. Click the scroll arrow to return to auto-scrolling");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, **IsScrollArrowVisible** confirms that the scroll arrow is currently visible on the chart.

![ChartControl_IsScrollArrowVisible](https://cdn.sanity.io/images/1hlwceal/production/0bb6ecfae5d7d73ec5d529ebd0c44f4c454d7c25-569x423.png)

#### ON THIS PAGE

*   [Definition](./isscrollarrowvisible.md)
*   [Property Value](./isscrollarrowvisible.md)
*   [Syntax](./isscrollarrowvisible.md)
*   [Examples](./isscrollarrowvisible.md)