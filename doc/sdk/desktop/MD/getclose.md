**Path**: [Bars](./bars.md) > [GetClose()](./getclose.md)

# GetClose()

# GetClose()

## [Definition](./getclose.md)

Returns the closing price at the current bar index value.

## [Method Return Value](./getclose.md)

A **double** value that represents the close price at the desired bar index.

## [Syntax](./getclose.md)

`Bars.GetClose(int index)`

## [Parameters](./getclose.md)

**index**

An int representing an absolute bar index value

## [Examples](./getclose.md)

```csharp

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   base.OnRender(chartControl, chartScale);
   // loop through only the rendered bars on the chart
   for(int barIndex = ChartBars.FromIndex; barIndex &lt;= ChartBars.ToIndex; barIndex++)
   {
     // get the close price at the selected bar index value
     double closePrice = Bars.GetClose(barIndex);
     Print("Bar #" + barIndex + " closing price is " + closePrice);
   }
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getclose.md)
*   [Method Return Value](./getclose.md)
*   [Syntax](./getclose.md)
*   [Parameters](./getclose.md)
*   [Examples](./getclose.md)