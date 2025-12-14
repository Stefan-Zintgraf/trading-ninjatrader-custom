**Path**: [Bars](./bars.md) > [GetLow()](./getlow.md)

# GetLow()

# GetLow()

## [Definition](./getlow.md)

Returns the low price at the selected bar index value.

## [Method Return Value](./getlow.md)

A **double** value that represents the low price at the desired bar index.

## [Syntax](./getlow.md)

`Bars.GetLow(int index)`

## [Parameters](./getlow.md)

**index**

An int representing an absolute bar index value

## [Examples](./getlow.md)

```csharp

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   base.OnRender(chartControl, chartScale);
   // loop through only the rendered bars on the chart
   for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)
   {
     // get the low price at the selected bar index value
     double lowPrice = Bars.GetLow(barIndex);
     Print("Bar #" + barIndex + " low price is " + lowPrice);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getlow.md)
*   [Method Return Value](./getlow.md)
*   [Syntax](./getlow.md)
*   [Parameters](./getlow.md)
*   [Examples](./getlow.md)