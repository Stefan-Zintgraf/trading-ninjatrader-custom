**Path**: [ChartScale](./chartscale.md) > [PanelIndex](./panelindex.md)

# PanelIndex

# PanelIndex

## [Definition](./panelindex.md)

The panel on which the chart scale resides.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This value is NOT the same value as the indicator's **PanelUI**. **PanelIndex** will provide the actual indexed value of the chart panel used for this chart scale.

## [Property Value](./panelindex.md)

An **int** value representing the panel as an index value which starts at 0 and will increment for each panel configured on the chart. This property is read\-only.

## [Syntax](./panelindex.md)

`<chartscale>.PanelIndex`

## [Examples](./panelindex.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{         
   // the index value of the panel (not the same as the panelUI)
   int     panel     = chartScale.PanelIndex;
   Print("panel: " + panel);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./panelindex.md)
*   [Property Value](./panelindex.md)
*   [Syntax](./panelindex.md)
*   [Examples](./panelindex.md)