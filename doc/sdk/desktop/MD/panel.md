**Path**: [ChartBars](./chartbars.md) > [Panel](./panel.md)

# Panel

# Panel

## [Definition](./panel.md)

A zero\-based index value that represents the **ChartPanel** where the **ChartBars** reside.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This is NOT the same as the **PanelUI** property displays on the Chart's **Data Series** menu. A **ChartBars.Panel** value of 0 represents the first panel on the chart.

## [Property Value](./panel.md)

An int indicating the panel of the **ChartBars**.

## [Syntax](./panel.md)

`Bars.Panel`

## [Examples](./panel.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
  Print("ChartBars reside on panel index: " + ChartBars.Panel);
  // Output:  ChartBars reside on panel index: 0        
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./panel.md)
*   [Property Value](./panel.md)
*   [Syntax](./panel.md)
*   [Examples](./panel.md)