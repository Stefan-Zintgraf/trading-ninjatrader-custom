**Path**: [Managed Approach](./managed_approach.md) > [ExitShortLimit()](./exitshortlimit.md)

# ExitShortLimit()

# ExitShortLimit()

## [Definition](./exitshortlimit.md)

Generates a buy to cover limit order to exit a short position.

## [Method Return Value](./exitshortlimit.md)

An **Order** read\-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Advanced Order Handling](./advanced_order_handling.md) section.

## [Syntax](./exitshortlimit.md)

`ExitShortLimit(double limitPrice)`

`ExitShortLimit(int quantity, double limitPrice)`

`ExitShortLimit(double limitPrice, string fromEntrySignal)`

`ExitShortLimit(double limitPrice, string signalName, string fromEntrySignal)`

`ExitShortLimit(int quantity, double limitPrice, string signalName, string fromEntrySignal)`

The following method variation is for experienced programmers who fully understand [Advanced Order Handling](./advanced_order_handling.md) concepts:

`ExitShortLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, string signalName, string fromEntrySignal)`

## [Parameters](./exitshortlimit.md)

**signalName**

User defined signal name identifying the order generated. Max 50 characters.

**fromEntrySignal**

The entry signal name. This ties the exit to the entry and exits the position quantity represented by the actual entry. Note: Using an empty string will attach the exit order to all entries.

**limitPrice**

The limit price of the order.

**quantity**

Entry order quantity.

**isLiveUntilCancelled**

The order will NOT expire at the end of a bar but instead remain live until the **CancelOrder()** method is called or its time in force is reached.

**barsInProgressIndex**

The index of the Bars object the order is to be submitted against. Used to determines what instrument the order is submitted for. See the [BarsInProgress](./barsinprogress.md) property.

## [Examples](./exitshortlimit.md)

```csharp
protected override void OnBarUpdate()
{
    if (CurrentBar < 20)
        return;

    // Only enter if at least 10 bars has passed since our last entry
    if ((BarsSinceEntryExecution() > 10 || BarsSinceEntryExecution() == -1) && CrossBelow(SMA(10), SMA(20), 1))
        EnterShort("SMA Cross Entry");

    // Exits position
    if (CrossAbove(SMA(10), SMA(20), 1))
        ExitShortLimit(GetCurrentAsk());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Tips](./exitshortlimit.md)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   This method is ignored if a short position does not exist
*   It is helpful to provide a signal name if your strategy has multiple exit points to help identify your exits on a chart
*   You can tie an exit to an entry by providing the entry signal name in the parameter "fromEntrySignal"
*   If you do not specify a quantity the entire position is exited rendering your strategy flat
*   If you do not specify a "fromEntrySignal" parameter the entire position is exited rendering your strategy flat

#### ON THIS PAGE

*   [Definition](./exitshortlimit.md)
*   [Method Return Value](./exitshortlimit.md)
*   [Syntax](./exitshortlimit.md)
*   [Parameters](./exitshortlimit.md)
*   [Examples](./exitshortlimit.md)
*   [Tips](./exitshortlimit.md)