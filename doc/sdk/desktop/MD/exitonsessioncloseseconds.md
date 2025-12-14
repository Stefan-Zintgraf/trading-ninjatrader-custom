**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [ExitOnSessionCloseSeconds](./exitonsessioncloseseconds.md)

# ExitOnSessionCloseSeconds

# ExitOnSessionCloseSeconds

## [Definition](./exitonsessioncloseseconds.md)

The number of seconds before the actual session end time that the **IsExitOnSessionCloseStrategy** function will trigger.

The time from which this property will be calculated is taken from the [Trading Hours](https://ninjatrader.com/support/helpguides/nt8/?trading_hours.htm) EOD property set in the strategy's Trading Hours template. The ExitOnSessionCloseSeconds property can either be set programmatically in the **OnStateChange()** method or be driven by the UI at run time.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This is a real\-time only property, it will not have any effect on your ExitOnSessionClose time in backtesting processing historical data.

## [Property Value](./exitonsessioncloseseconds.md)

An int representing the number of seconds. Default value is 30.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults or State.Configure.

## [Syntax](./exitonsessioncloseseconds.md)

`ExitOnSessionCloseSeconds`

## [Examples](./exitonsessioncloseseconds.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         // Triggers the exit on close function 30 seconds prior to trading day end 
         IsExitOnSessionCloseStrategy = true;
         ExitOnSessionCloseSeconds = 30;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./exitonsessioncloseseconds.md)
*   [Property Value](./exitonsessioncloseseconds.md)
*   [Syntax](./exitonsessioncloseseconds.md)
*   [Examples](./exitonsessioncloseseconds.md)