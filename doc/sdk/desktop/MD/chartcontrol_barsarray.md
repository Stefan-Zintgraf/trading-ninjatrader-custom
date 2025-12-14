**Path**: [ChartControl](./chartcontrol.md) > [BarsArray](./chartcontrol_barsarray.md)

# BarsArray

# BarsArray

## [Definition](./chartcontrol_barsarray.md)

Provides a collection of **ChartBars** objects currently configured on the chart.

## [Property Value](./chartcontrol_barsarray.md)

An **ObservableCollection** of **ChartBars** objects.

## [Syntax](./chartcontrol_barsarray.md)

`<chartcontrol>.BarsArray`

## [Examples](./chartcontrol_barsarray.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Instantiate a new <chartcontrol`>.BarsArray collection
   System.Collections.ObjectModel.ObservableCollection<chartbars> myChartBars = chartControl.BarsArray;
 
   // Print the number of bars in each Bars object within the <chartcontrol`>.BarsArray collection
   foreach(ChartBars bars in myChartBars)
   {
       Print(bars.Bars.Count);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartcontrol_barsarray.md)
*   [Property Value](./chartcontrol_barsarray.md)
*   [Syntax](./chartcontrol_barsarray.md)
*   [Examples](./chartcontrol_barsarray.md)