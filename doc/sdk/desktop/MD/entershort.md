**Path**: [Managed Approach](./managed_approach.md) > [EnterShort()](./entershort.md)

# EnterShort()

# EnterShort()

## [Definition](./entershort.md)

Generates a sell short market order to enter a short position.

## [Method Return Value](./entershort.md)

An **Order** read\-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Advanced Order Handling](./advanced_order_handling.md) section.

## [Syntax](./entershort.md)

`EnterShort()`

`EnterShort(string signalName)`

`EnterShort(int quantity)`

`EnterShort(int quantity, string signalName)`

The following method variation is for experienced programmers who fully understand [Advanced Order Handling](./advanced_order_handling.md) concepts:

`EnterShort(int barsInProgressIndex, int quantity, string signalName)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If using a method signature that does not have the parameter quantity, the order quantity will be taken from the quantity value set in the strategy dialog window when running or backtesting a strategy.

## [Parameters](./entershort.md)

Parameter

Description

**signalName**

User defined signal name identifying the order generated. Max 50 characters.

**quantity**

Entry order quantity (if 0 is passed in, will be set to 1, except for stocks 100).

**barsInProgressIndex**

The index of the Bars object the order is to be submitted against. Used to determine what instrument the order is submitted for. See the [BarsInProgress](./barsinprogress.md) property.

## [Examples](./entershort.md)

```csharp
protected override void OnBarUpdate()
{
     if (CurrentBar < 20)
         return;

     // Only enter if at least 10 bars has passed since our last entry
     if ((BarsSinceEntryExecution() > 10 || BarsSinceEntryExecution() == -1) && CrossAbove(SMA(10), SMA(20), 1))
         EnterShort("SMA Cross Entry");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./entershort.md)
*   [Method Return Value](./entershort.md)
*   [Syntax](./entershort.md)
*   [Parameters](./entershort.md)
*   [Examples](./entershort.md)