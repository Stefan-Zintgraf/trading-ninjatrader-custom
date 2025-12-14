**Path**: [ChartControl](./chartcontrol.md) > [ChartPanels](./chartpanels.md)

# ChartPanels

# ChartPanels

## [Definition](./chartpanels.md)

Holds a collection of **ChartPanel** objects containing information about the panels active on the chart.

## [Property Value](./chartpanels.md)

An **ObservableCollection** of **ChartPanel** objects

## [Syntax](./chartpanels.md)

`<chartcontrol>.ChartPanels`

## [Examples](./chartpanels.md)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Based on the image below, there are three ChartPanel objects in the ChartPanels collection, as seen by **ChartPanels.Count** in the code above.

![ChartControl_ChartPanels](https://cdn.sanity.io/images/1hlwceal/production/e617b92f4c2da0945b6852745d6a83c733e787ed-533x432.png)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print the number of panels currently displayed on the chart
   Print(String.Format("There are {0} panels on the chart", chartControl.ChartPanels.Count));  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartpanels.md)
*   [Property Value](./chartpanels.md)
*   [Syntax](./chartpanels.md)
*   [Examples](./chartpanels.md)