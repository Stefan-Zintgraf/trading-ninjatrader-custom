**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [BarsSinceExitExecution()](./barssinceexitexecution.md)

# BarsSinceExitExecution()

# BarsSinceExitExecution()

## [Definition](./barssinceexitexecution.md)

Returns the number of bars that have elapsed since the last exit. When a signal name is provided, the number of bars that have elapsed since that last specific exit will be returned.

## [Method Return Value](./barssinceexitexecution.md)

An **int** value that represents a number of bars. A value of \-1 will be returned if a previous exit does not exist.

## [Syntax](./barssinceexitexecution.md)

`BarsSinceExitExecution()`

`BarsSinceExitExecution(string signalName)`

The following method signature should be used when working with [multi\-time frame and instrument strategies](./multi_time_frame_instruments.md):

BarsSinceExitExecution(int barsInProgressIndex, string signalName, int exitExecutionsAgo)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When working with a multi\-series strategy the BarsSinceExitExecution() will return you the elapsed bars as determined by the first Bars object for the instrument specified in the barsInProgressIndex.

## [Parameters](./barssinceexitexecution.md)

signalName

The signal name of an exit order specified in an order exit method.

barsInProgressIndex

The index of the Bars object the entry order was submitted against. See the [BarsInProgress](./barsinprogress.md) property.

exitExecutionsAgo

Number of exit executions ago. Pass in 0 for the number of bars since the last exit execution.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Please see [SetStopLoss()](./setstoploss.md), [SetProfitTarget()](./setprofittarget.md) or [SetTrailStop()](./settrailstop.md) for their corresponding signal name

## [Examples](./barssinceexitexecution.md)

```csharp
protected override void OnBarUpdate()
{ 
   if (CurrentBar < BarsRequiredToTrade) 
       return; 

   // Only enter if at least 10 bars has passed since our last exit or if we have never traded yet
   if ((BarsSinceExitExecution() > 10 || BarsSinceExitExecution() == -1) && CrossAbove(SMA(10), SMA(20), 1))
       EnterLong();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barssinceexitexecution.md)
*   [Method Return Value](./barssinceexitexecution.md)
*   [Syntax](./barssinceexitexecution.md)
*   [Parameters](./barssinceexitexecution.md)
*   [Examples](./barssinceexitexecution.md)