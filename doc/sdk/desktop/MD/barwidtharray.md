**Path**: [ChartControl](./chartcontrol.md) > [BarWidthArray](./barwidtharray.md)

# BarWidthArray

# BarWidthArray

## [Definition](./barwidtharray.md)

An array containing the values of the [BarWidth](./barwidth.md) properties of all Bars objects applied to the chart.

## [Property Value](./barwidtharray.md)

An array of double variables containing the values of the BarWidth properties of Bars objects on the chart.

## [Syntax](./barwidtharray.md)

`ChartControl.BarWidthArray[]`

## [Examples](./barwidtharray.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Assign BarWidthArray to a new array
   double[] barWidths = chartControl.BarWidthArray;
 
   double referenceWidth = barWidths[0];
 
   // Trigger an alert if bar widths on the chart differ
   foreach (double width in barWidths)
   {
       if (width != referenceWidth)
           Alert("mismatchWidths", Priority.Low, "Bar widths on the chart do not match!", " ", 20, Brushes.White, Brushes.Black);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barwidtharray.md)
*   [Property Value](./barwidtharray.md)
*   [Syntax](./barwidtharray.md)
*   [Examples](./barwidtharray.md)