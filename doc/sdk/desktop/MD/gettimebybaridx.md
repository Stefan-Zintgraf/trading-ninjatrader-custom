**Path**: [ChartBars](./chartbars.md) > [GetTimeByBarIdx()](./gettimebybaridx.md)

# GetTimeByBarIdx()

# GetTimeByBarIdx()

## [Definition](./gettimebybaridx.md)

Returns the **ChartBars** time value calculated from a bar index parameter provided.

## [Method Return Value](./gettimebybaridx.md)

A **DateTime** struct representing a bar time value at a specific bar index value.

## [Syntax](./gettimebybaridx.md)

`ChartBars.GetTimeByBarIdx(ChartControl chartControl, int barIndex)`

## [Method Parameters](./gettimebybaridx.md)

**chartControl**

The **ChartControl** object used to determine the chart's time axis

**barIndex**

An **int** value representing a bar index used to convert to a **ChartBar** index value

## [Examples](./gettimebybaridx.md)

```csharp
protected override void OnBarUpdate()
{
   if (ChartBars != null)
   {
     Print(ChartBars.GetTimeByBarIdx(ChartControl, 50)); //8/11/2015 4:30:00 AM
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettimebybaridx.md)
*   [Method Return Value](./gettimebybaridx.md)
*   [Syntax](./gettimebybaridx.md)
*   [Method Parameters](./gettimebybaridx.md)
*   [Examples](./gettimebybaridx.md)