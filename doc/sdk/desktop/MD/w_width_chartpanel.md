**Path**: [ChartPanel](./chartpanel.md) > [W (Width)](./w_width_chartpanel.md)

# W (Width)

# W (Width)

## [Definition](./w_width_chartpanel.md)

Indicates the width (in pixels) of the paintable area of the chart panel.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The paintable area does not extend all the way to the right edge of the panel itself, as seen in the image below.

## [Property Value](./w_width_chartpanel.md)

A **int** representing the width of the panel in pixels

## [Syntax](./w_width_chartpanel.md)

`ChartPanel.W`

## [Example](./w_width_chartpanel.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  
{  
  base.OnRender(chartControl, chartScale);  
     
  // Print the width of the panel  
  Print(ChartPanel.W);  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, W reveals that the chart panel is 451 pixels wide.

![chartpanel_w](https://cdn.sanity.io/images/1hlwceal/production/272505438485c2b076f0066d6626100aea434e0b-534x433.png)

#### ON THIS PAGE

*   [Definition](./w_width_chartpanel.md)
*   [Property Value](./w_width_chartpanel.md)
*   [Syntax](./w_width_chartpanel.md)
*   [Example](./w_width_chartpanel.md)