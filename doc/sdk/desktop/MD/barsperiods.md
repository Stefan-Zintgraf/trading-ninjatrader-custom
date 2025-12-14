**Path**: [AddDataSeries()](./adddataseries.md) > [BarsPeriods](./barsperiods.md)

# BarsPeriods

# BarsPeriods

## [Definition](./barsperiods.md)

Holds an array of BarsPeriod objects synchronized to the number of unique Bars objects held within the parent NinjaScript object. If a NinjaScript object holds two Bars series, then BarsPeriods will hold two BarsPeriod objects.

## [Property Value](./barsperiods.md)

An array of [BarsPeriod](./barsperiod.md) objects.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should NOT be accessed within the [OnStateChange()](./onstatechange.md) method before the State has reached State.DataLoaded

## [Syntax](./barsperiods.md)

`BarsPeriods[int barSeriesIndex]`

## [Examples](./barsperiods.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.Configure)
     {
         // Adds a 5-minute Bars object to the strategy and is automatically assigned 
         // a Bars object index of 1 since the original data the strategy is ran on,
         // set by the UI, takes the index of 0. 
         AddDataSeries("AAPL", BarsPeriodType.Minute, 5); 
     }
} 

protected override void OnBarUpdate() 
{ 
     // Print out 5, the value of the secondary bars object 
     if (BarsInProgress == 1)
         Print(BarsPeriods[1].Value);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barsperiods.md)
*   [Property Value](./barsperiods.md)
*   [Syntax](./barsperiods.md)
*   [Examples](./barsperiods.md)