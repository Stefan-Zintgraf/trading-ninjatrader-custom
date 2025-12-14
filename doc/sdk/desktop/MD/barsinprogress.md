**Path**: [AddDataSeries()](./adddataseries.md) > [BarsInProgress](./barsinprogress.md)

# BarsInProgress

# BarsInProgress

## [Definition](./barsinprogress.md)

An index value of the current Bars object that has called the [OnBarUpdate](./onbarupdate.md) method. In a multi\-bars script, the OnBarUpdate() method is called for each Bars object of a script. This flexibility allows you to separate trading logic from different bar events.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  In a single Bars script this property will always return an index value of 0 representing the primary Bars and instrument the script is running on.
2.  See additional information on running [multi\-bars scripts](./multi_time_frame_instruments.md).

## [Property Value](./barsinprogress.md)

An **int** value represents the [Bars](./bars.md) object that is calling the OnBarUpdate() method.

## [Syntax](./barsinprogress.md)

`BarsInProgress`

## [Examples](./barsinprogress.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.Configure)
     {
         // Add a 5 minute Bars object: BarsInProgress index = 1 
         AddDataSeries(BarsPeriodType.Minute, 5);
     }
} 

protected override void OnBarUpdate() 
{ 
     // Check which Bars object is calling the OnBarUpdate() method 
     if (BarsInProgress == 0) 
     { 
         // A value of zero represents the primary Bars which is the ES 09-14 
         // 1 minute chart. 
         // Do something within the context of the 1 minute Bars here 
     } 
     else if (BarsInProgress == 1) 
     { 
         // A value of 1 represents the secondary 5 minute bars added in OnStateChange() State.Configure 
         // Do something within the context of the 5 minute Bars 
     } 
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barsinprogress.md)
*   [Property Value](./barsinprogress.md)
*   [Syntax](./barsinprogress.md)
*   [Examples](./barsinprogress.md)