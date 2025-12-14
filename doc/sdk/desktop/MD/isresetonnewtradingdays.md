**Path**: [OnBarUpdate()](./onbarupdate.md) > [IsResetOnNewTradingDays](./isresetonnewtradingdays.md)

# IsResetOnNewTradingDays

# IsResetOnNewTradingDays

## [Definition](./isresetonnewtradingdays.md)

Determines if the specified bar series iusing Break at EOD

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The property available on the UI will override any values set in code. Please see the help guide topic on using **Break at EOD** for more information.

## [Property Value](./isresetonnewtradingdays.md)

A **bool\[\]** when true, indicates the specified [BarsArray](./barsarray.md) is setup to run Break at EOD; otherwise false. Default value is false.

## [Syntax](./isresetonnewtradingdays.md)

`IsResetOnNewTradingDays[int idx]`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should NOT be accessed within the [OnStateChange()](./onstatechange.md) method before the State has reached State.DataLoaded.

## [Examples](./isresetonnewtradingdays.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Name = "Examples Indicator";
   }

   else if (State == State.Configure)
   {
     //Add AAPL 1 minute with RTH trading hours, set to break EOD
     AddDataSeries("AAPL", new BarsPeriod() { BarsPeriodType = BarsPeriodType.Minute, Value = 1 }, 50, "US Equities RTH", true);
   }

}
protected override void OnBarUpdate()
{
 //Print out the current bars series name and break EOD setting on start up
 //   IsResetOnNewTradingDays[0]  Primary
 //   IsResetOnNewTradingDays[1]  AAPL

 if (CurrentBar == 0)
   Print(BarsArray[BarsInProgress].ToChartString() + " " + IsResetOnNewTradingDays[BarsInProgress]);

 //Output:  
 //ES 03-15 (1 Minute) True
 //AAPL (1 Minute) False

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isresetonnewtradingdays.md)
*   [Property Value](./isresetonnewtradingdays.md)
*   [Syntax](./isresetonnewtradingdays.md)
*   [Examples](./isresetonnewtradingdays.md)