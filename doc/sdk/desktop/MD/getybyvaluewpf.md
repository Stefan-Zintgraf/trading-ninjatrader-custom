**Path**: [ChartScale](./chartscale.md) > [GetYByValueWpf()](./getybyvaluewpf.md)

# GetYByValueWpf()

# GetYByValueWpf()

## [Definition](./getybyvaluewpf.md)

Returns a WPF coordinate on the chart determined by a series value represented on the chart scale.

## [Method Return Value](./getybyvaluewpf.md)

An double value representing a WPF coordinate on the chart scale.

## [Syntax](./getybyvaluewpf.md)

`<chartscale>.GetYByValueWpf(double val)`

## [Method Parameters](./getybyvaluewpf.md)

**val**

A **double** value which usually represents a price or indicator value

## [Examples](./getybyvaluewpf.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // gets the wpf coordinate of the price value passed to the method
   int     valueByYWpf = chartScale.GetYByValueWpf(Bars.GetClose(Bars.Count - 1));

   Print("valueByYWpf: " + valueByYWpf); // 207
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, we pass the last bar close as the value (example logic avoids using a bars ago index, see also [**OnRender()**](./onrender.md) note #5), which in return tells us the last price displayed on the chart is at a WPF location of 207.30998 pixels.

![GetYByValueWpf](https://cdn.sanity.io/images/1hlwceal/production/38864dedc584e71437d7643c2748a1576a21ce3c-535x433.png)

#### ON THIS PAGE

*   [Definition](./getybyvaluewpf.md)
*   [Method Return Value](./getybyvaluewpf.md)
*   [Syntax](./getybyvaluewpf.md)
*   [Method Parameters](./getybyvaluewpf.md)
*   [Examples](./getybyvaluewpf.md)