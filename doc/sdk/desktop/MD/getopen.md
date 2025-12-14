**Path**: [Bars](./bars.md) > [GetOpen()](./getopen.md)

# GetOpen()

# GetOpen()

## [Definition](./getopen.md)

Returns the open price at the selected bar index value.

## [Method Return Value](./getopen.md)

A **double** value that represents the open price at the desired bar index.

## [Syntax](./getopen.md)

`Bars.GetOpen(int index)`

## [Parameters](./getopen.md)

**index**

An int representing an absolute bar index value

## [Examples](./getopen.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   base.OnRender(chartControl, chartScale);
   // loop through only the rendered bars on the chart
   for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)
   {
     // get the open price at the selected bar index value
     double openPrice = Bars.GetOpen(barIndex);
     Print("Bar #" + barIndex + " open price is " + openPrice);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getopen.md)
*   [Method Return Value](./getopen.md)
*   [Syntax](./getopen.md)
*   [Parameters](./getopen.md)
*   [Examples](./getopen.md)