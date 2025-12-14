**Path**: [Analytical](./analytical.md) > [GetCurrentAskVolume()](./getcurrentaskvolume.md)

# GetCurrentAskVolume()

# GetCurrentAskVolume()

## [Definition](./getcurrentaskvolume.md)

Returns the current real\-time ask volume.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  When accessed during **State.Historical**, the [Volume](./volume.md) of the evaluated bar series is substituted. To access historical Ask Volumes, please see [Developing for Tick Replay](./developing_for_tick_replay.md).
2.  The **GetCurrentAskVolume()** method runs on the bar series currently updating determined by the **BarsInProgress** property. For [multi\-instrument](./multi_time_frame_instruments.md) scripts, an additional int "barsSeriesIndex" parameter can be supplied which forces the method to run on a supplementary bar series.

## [Method Return Value](./getcurrentaskvolume.md)

A long value representing the current ask volume.

## [Syntax](./getcurrentaskvolume.md)

`GetCurrentAskVolume()`

`GetCurrentAskVolume(int barsSeriesIndex)`

## [Parameters](./getcurrentaskvolume.md)

Parameter

Description

barsSeriesIndex

An **int** value determining the bar series the method runs. Note: This optional parameter is reserved for multi\-instrument scripts

## [Examples](./getcurrentaskvolume.md)

```csharp
protected override void OnBarUpdate()
{
   long currentAskVolume = GetCurrentAskVolume();
   Print("The Current Ask volume is: " + currentAskVolume);
   //The Current Ask volume is: 158
}

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
protected override void OnBarUpdate()
{
   if(BarsInProgress == 0)
   {
     long currentAskVolume = GetCurrentAskVolume(0);
     Print("The Current Ask volume is: " + currentAskVolume);
     //The Current Ask volume is: 346
   }

   if(BarsInProgress == 1)

   {

     long msftAskVolume = GetCurrentAskVolume(1);

     Print("MSFT's Current Ask volume is: " + msftAskVolume);

     //MSFT's Current Ask volume is: 1548

   }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getcurrentaskvolume.md)
*   [Method Return Value](./getcurrentaskvolume.md)
*   [Syntax](./getcurrentaskvolume.md)
*   [Parameters](./getcurrentaskvolume.md)
*   [Examples](./getcurrentaskvolume.md)