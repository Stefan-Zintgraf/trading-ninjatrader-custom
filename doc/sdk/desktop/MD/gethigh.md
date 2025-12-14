**Path**: [Bars](./bars.md) > [GetHigh()](./gethigh.md)

# GetHigh()

# GetHigh()

## [Definition](./gethigh.md)

Returns the high price at the selected bar index value.

## [Method Return Value](./gethigh.md)

A **double** value that represents the high price at the desired bar index.

## [Syntax](./gethigh.md)

`Bars.GetHigh(int index)`

## [Parameters](./gethigh.md)

**index**

An int representing an absolute bar index value

## [Examples](./gethigh.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   base.OnRender(chartControl, chartScale);
   // loop through only the rendered bars on the chart
   for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)
   {
     // get the high price at the selected bar index value
     double highPrice = Bars.GetHigh(barIndex);
     Print("Bar #" + barIndex + " high price is " + highPrice);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gethigh.md)
*   [Method Return Value](./gethigh.md)
*   [Syntax](./gethigh.md)
*   [Parameters](./gethigh.md)
*   [Examples](./gethigh.md)