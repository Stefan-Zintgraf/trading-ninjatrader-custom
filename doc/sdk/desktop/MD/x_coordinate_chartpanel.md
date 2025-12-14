**Path**: [ChartPanel](./chartpanel.md) > [X (Coordinate)](./x_coordinate_chartpanel.md)

# X (Coordinate)

# X (Coordinate)

## [Definition](./x_coordinate_chartpanel.md)

Indicates the **x\-coordinate** on the chart canvas at which the chart panel begins.

## [Property Value](./x_coordinate_chartpanel.md)

A **int** representing the **x\-coordinate** at which the panel begins. This property will only contain a value greater than zero if the y\-axis displays to the left of the paintable chart canvas area in the panel (if an object in the panel is using the "Left" scale justification).

## [Syntax](./x_coordinate_chartpanel.md)

`ChartPanel.X`

## [Example](./x_coordinate_chartpanel.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  
{  
  base.OnRender(chartControl, chartScale);  
     
  // Print the coordinates of the top-left corner of the panel  
  Print(String.Format("The panel begins at coordinates {0},{1}",ChartPanel.X ,ChartPanel.Y));  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, X reveals that the chart panel begins at x\-coordinate 52.

![chartpanel_x](https://cdn.sanity.io/images/1hlwceal/production/8402fb76e4bbd193ca8526d08bea24079a23fcd6-534x433.png)

#### ON THIS PAGE

*   [Definition](./x_coordinate_chartpanel.md)
*   [Property Value](./x_coordinate_chartpanel.md)
*   [Syntax](./x_coordinate_chartpanel.md)
*   [Example](./x_coordinate_chartpanel.md)