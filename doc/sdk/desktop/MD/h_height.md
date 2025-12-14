**Path**: [ChartPanel](./chartpanel.md) > [H (Height)](./h_height.md)

# H (Height)

# H (Height)

## [Definition](./h_height.md)

Indicates the height (in pixels) of the rendered area of the chart panel.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The paintable area does not extend all the way to the top edge of the panel itself, as seen in the image below.

## [Property Value](./h_height.md)

A int representing the height of the panel in pixels.

## [Syntax](./h_height.md)

`ChartPanel.H`

## [Examples](./h_height.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);
    
    // Print the height of the panel
    Print(ChartPanel.H);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, H reveals that the paintable area of the chart panel is 69 pixels high.

![ChartPanel_H](https://cdn.sanity.io/images/1hlwceal/production/7276ede93b5a4b991340373863b85b320cbea7f4-534x433.png)

#### ON THIS PAGE

*   [Definition](./h_height.md)
*   [Property Value](./h_height.md)
*   [Syntax](./h_height.md)
*   [Examples](./h_height.md)