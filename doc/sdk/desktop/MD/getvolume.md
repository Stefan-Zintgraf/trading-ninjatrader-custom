**Path**: [Bars](./bars.md) > [GetVolume()](./getvolume.md)

# GetVolume()

# GetVolume()

## [Definition](./getvolume.md)

Returns the volume at the selected bar index value.

## [Method Return Value](./getvolume.md)

A long value represents the volume at the desired bar index.

## [Syntax](./getvolume.md)

`Bars.GetVolume(int index)`

## [Parameters](./getvolume.md)

index

An int representing an absolute bar index value

## [Examples](./getvolume.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   base.OnRender(chartControl, chartScale);
   // loop through all the rendered bars on the chart
   for(int barIndex = ChartBars.FromIndex; barIndex &lt;= ChartBars.ToIndex; barIndex++)
   {
     // get the volume value at the selected bar index value
     long volumeValue = Bars.GetVolume(barIndex);
     Print("Bar #" + barIndex + " volume value is " + volumeValue);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getvolume.md)
*   [Method Return Value](./getvolume.md)
*   [Syntax](./getvolume.md)
*   [Parameters](./getvolume.md)
*   [Examples](./getvolume.md)