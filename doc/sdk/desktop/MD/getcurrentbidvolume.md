**Path**: [Analytical](./analytical.md) > [GetCurrentBidVolume()](./getcurrentbidvolume.md)

# GetCurrentBidVolume()

# GetCurrentBidVolume()

## [Definition](./getcurrentbidvolume.md)

Returns the current real\-time bid volume.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  When accessed during **State.Historical**, the [Volume](./volume.md) of the evaluated bar series is substituted. To access historical Bid Volumes, please see [Developing for Tick Replay](./developing_for_tick_replay.md).
2.  The **GetCurrentBidVolume()** method runs on the bar series currently updating determined by the **BarsInProgress** property. For [multi\-instrument](./multi_time_frame_instruments.md) scripts, an additional int "barsSeriesIndex" parameter can be supplied which forces the method to run on a supplementary bar series.

## [MethoReturn Value](./getcurrentbidvolume.md)

A long value representing the current bid volume.

## [Syntax](./getcurrentbidvolume.md)

`GetCurrentBidVolume()`

`GetCurrentBidVolume(int barsSeriesIndex)`

## [Parameters](./getcurrentbidvolume.md)

Parameter

Description

**barsSeriesIndex**

An **int** value determining the bar series the method runs. Note: This optional parameter is reserved for multi\-instrument scripts

## [Examples](./getcurrentbidvolume.md)

```csharp
protected override void OnBarUpdate()
{
   long currentBidVolume = GetCurrentBidVolume();
   Print("The Current Bid volume is: " + currentBidVolume);
   //The Current Bid volume is: 158
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Name = "Examples Indicator";
   }
   if (State == State.Configure)
   {
     //Add MSFT as our additional data series
     AddDataSeries("MSFT", BarsPeriodType.Minute, 1);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
protected override void OnBarUpdate()
{
   if(BarsInProgress == 0)
   {
     long currentBidVolume = GetCurrentBidVolume(0);
     Print("The Current Bid volume is: " + currentBidVolume);
     //The Current Bid volume is: 346
   }

   if(BarsInProgress == 1)

   {

     long msftBidVolume = GetCurrentBidVolume(1);

     Print("MSFT's Current Bid volume is: " + msftBidVolume);

     //MSFT's Current Bid volume is: 1548

   }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getcurrentbidvolume.md)
*   [MethoReturn Value](./getcurrentbidvolume.md)
*   [Syntax](./getcurrentbidvolume.md)
*   [Parameters](./getcurrentbidvolume.md)
*   [Examples](./getcurrentbidvolume.md)