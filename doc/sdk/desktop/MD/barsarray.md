**Path**: [AddDataSeries()](./adddataseries.md) > [BarsArray](./barsarray.md)

# BarsArray

# BarsArray

## [Definition](./barsarray.md)

An array holding Bars objects that are added via the [AddDataSeries()](./adddataseries.md) method. BarsArray can be used as input for [indicator methods](./system_indicator_methods.md). This property is of primary value when working with [multi\-time frame or multi\-instrument scripts](./multi_time_frame_instruments.md).

## [Property Value](./barsarray.md)

An array of [Bars](./bars.md) objects.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should NOT be accessed within the [OnStateChange()](./onstatechange.md) method before the State has reached **State.DataLoaded**

## [Syntax](./barsarray.md)

`BarsArray[int index]`

## [Examples](./barsarray.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name = "Examples Indicator";      
    }
    else if (State == State.Configure)
    {
        // Add a 5 minute Bars object which is added to the BarArray 
        // which will take index 1 since the primary Bars object of the strategy 
        // will be index 0 
        AddDataSeries(BarsPeriodType.Minute, 5); 
    }
} 

protected override void OnBarUpdate() 
{ 
    // Ignore bar update events for the supplementary Bars object added above 
    if (BarsInProgress == 1) 
        return; 

    // Pass in a Bars object as input for the simple moving average method 
    // Evaluates if the 20 SMA of the primary Bars is greater than 
    // the 20 SMA of the secondary Bars added above 
    if (SMA(20)[0] > SMA(BarsArray[1], 20)[0]) 
        EnterLong(); 
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barsarray.md)
*   [Property Value](./barsarray.md)
*   [Syntax](./barsarray.md)
*   [Examples](./barsarray.md)