**Path**: [ChartPanel](./chartpanel.md) > [Y (Coordinate)](./y_coordinate_chartpanel.md)

# Y (Coordinate)

# Y (Coordinate)

## [Definition](./y_coordinate_chartpanel.md)

Indicates the **y\-coordinate** on the chart canvas at which the chart panel begins.

## [Property Value](./y_coordinate_chartpanel.md)

A **int** representing the **y\-coordinate** at which the panel begins.

## [Syntax](./y_coordinate_chartpanel.md)

`ChartPanel.Y`

## [Example](./y_coordinate_chartpanel.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  
{  
  base.OnRender(chartControl, chartScale);  
     
  // Print the coordinates of the top-left corner of the panel  
  Print(String.Format("The panel begins at coordinates {0},{1}",ChartPanel.X ,ChartPanel.Y));  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, Y reveals that the chart panel begins at y\-coordinate 232.

![chartpanel_y](https://cdn.sanity.io/images/1hlwceal/production/a4f39c5505ac60533a86ccc155406dd304d0bfb9-534x433.png)

#### ON THIS PAGE

*   [Definition](./y_coordinate_chartpanel.md)
*   [Property Value](./y_coordinate_chartpanel.md)
*   [Syntax](./y_coordinate_chartpanel.md)
*   [Example](./y_coordinate_chartpanel.md)