**Path**: [ChartControl](./chartcontrol.md) > [IsYAxisDisplayedLeft](./isyaxisdisplayedleft.md)

# IsYAxisDisplayedLeft

# IsYAxisDisplayedLeft

## [Definition](./isyaxisdisplayedleft.md)

Indicates the y\-axis displays (in any chart panel) to the left side of the chart.

## [Property Value](./isyaxisdisplayedleft.md)

A **boolean** value. When True, indicates that the y\-axis displays to the left of the chart canvas; otherwise False.

## [Syntax](./isyaxisdisplayedleft.md)

`<ChartControl>.IsYAxisDisplayedLeft`

## [Examples](./isyaxisdisplayedleft.md)

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  
{  
  // Print the value of IsYAxisDisplayedLeft  
  Print("Y\-Axis visible to the left of the chart canvas? " + chartControl.IsYAxisDisplayedLeft);  
}

Based on the image below, IsYAxisDisplayedLeft confirms that the y\-axis displays to the left of the chart canvas.

![ChartControl_isYAxisDisplayedLeft](https://cdn.sanity.io/images/1hlwceal/production/1a8a2e6f6f5dd77dcd5c74433f52018c36346c4e-575x429.png)

#### ON THIS PAGE

*   [Definition](./isyaxisdisplayedleft.md)
*   [Property Value](./isyaxisdisplayedleft.md)
*   [Syntax](./isyaxisdisplayedleft.md)
*   [Examples](./isyaxisdisplayedleft.md)