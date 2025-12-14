**Path**: [ChartBars](./chartbars.md) > [Count](./chartbars_count.md)

# Count

# Count

## [Definition](./chartbars_count.md)

The total number of **ChartBars** in the charts primary data series.

## [Property Value](./chartbars_count.md)

An **int** value representing the total number of bars.

## [Syntax](./chartbars_count.md)

`ChartBars.Count`

## [Examples](./chartbars_count.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   if(ChartBars != null)
   {
     Print("ChartBars contain " + ChartBars.Count + " bars");
     //Output:  ChartBars contain 73 bars
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartbars_count.md)
*   [Property Value](./chartbars_count.md)
*   [Syntax](./chartbars_count.md)
*   [Examples](./chartbars_count.md)