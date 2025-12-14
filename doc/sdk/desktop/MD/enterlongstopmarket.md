**Path**: [Managed Approach](./managed_approach.md) > [EnterLongStopMarket()](./enterlongstopmarket.md)

# EnterLongStopMarket()

# EnterLongStopMarket()

## [Definition](./enterlongstopmarket.md)

Generates a buy stop market order to enter a long position.

## [Method Return Value](./enterlongstopmarket.md)

An **Order** read\-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Advanced Order Handling](./advanced_order_handling.md) section.

## [Syntax](./enterlongstopmarket.md)

`EnterLongStopMarket(double stopPrice)`

`EnterLongStopMarket(double stopPrice, string signalName)`

`EnterLongStopMarket(int quantity, double stopPrice)`

`EnterLongStopMarket(int quantity, double stopPrice, string signalName)`

**The following method variation is for experienced programmers who fully understand [Advanced Order Handling](./advanced_order_handling.md) concepts:**

`EnterLongStopMarket(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If using a method signature that does not have the parameter quantity, the order quantity will be taken from the quantity value set in the strategy dialog window when running or backtesting a strategy.

## [Parameters](./enterlongstopmarket.md)

**signalName**

User defined signal name identifying the order generated. Max 50 characters.

**stopPrice**

The stop price of the order.

**quantity**

Entry order quantity (if 0 is passed in, will be set to 1, except for stocks 100).

**isLiveUntilCancelled**

The order will NOT expire at the end of a bar, but instead remain live until the [CancelOrder()](./cancelorder.md) method is called or its time in force is reached.

**barsInProgressIndex**

The index of the Bars object the order is to be submitted against. Used to determine what instrument the order is submitted for. See the [BarsInProgress](./barsinprogress.md) property.

## [Examples](./enterlongstopmarket.md)

```csharp
protected override void OnBarUpdate()
{
    if (CurrentBar < 20)
        return;

    // Only enter if at least 10 bars has passed since our last entry
    if ((BarsSinceEntryExecution() > 10 || BarsSinceEntryExecution() == -1) && CrossAbove(SMA(10), SMA(20), 1))
        EnterLongStopMarket(GetCurrentAsk() + TickSize, "SMA Cross Entry");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./enterlongstopmarket.md)
*   [Method Return Value](./enterlongstopmarket.md)
*   [Syntax](./enterlongstopmarket.md)
*   [Parameters](./enterlongstopmarket.md)
*   [Examples](./enterlongstopmarket.md)