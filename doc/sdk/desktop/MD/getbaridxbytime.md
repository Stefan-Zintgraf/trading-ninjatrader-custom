**Path**: [ChartBars](./chartbars.md) > [GetBarIdxByTime()](./getbaridxbytime.md)

# GetBarIdxByTime()

# GetBarIdxByTime()

## [Definition](./getbaridxbytime.md)

Returns the **ChartBars** index value calculated from the time parameter provided.

## [Method Return Value](./getbaridxbytime.md)

An **int** representing the bar index value at a specific time.

## [Syntax](./getbaridxbytime.md)

`ChartBars.GetBarIdxByTime(ChartControl chartControl, DateTime time)`

## [Method Parameters](./getbaridxbytime.md)

**chartControl**

The **ChartControl** object used to determine the chart's time axis

**time**

The **DateTime** value used to convert to a ChartBar index value

## [Examples](./getbaridxbytime.md)

```csharp

protected override void OnBarUpdate()
{
   if (ChartBars != null)
   {
     Print(ChartBars.GetBarIdxByTime(ChartControl, Time[0]));  
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getbaridxbytime.md)
*   [Method Return Value](./getbaridxbytime.md)
*   [Syntax](./getbaridxbytime.md)
*   [Method Parameters](./getbaridxbytime.md)
*   [Examples](./getbaridxbytime.md)