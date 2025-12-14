**Path**: [Order](./order.md) > [IsTerminalState()](./isterminalstate.md)

# IsTerminalState()

# IsTerminalState()

## [Definition](./isterminalstate.md)

A static method used to determine if the an order's **OrderState** is considered terminal and no longer active.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This is a static method and is compared against an order state, NOT the order itself. Please see the example below for correct syntax and usage.

## [Method Return Value](./isterminalstate.md)

A bool value which will return true when an **OrderState** is equal to **OrderState.Cancelled**, **OrderState.Filled**, **OrderState.Rejected**, **OrderState.Unknown**; otherwise false.

## [Syntax](./isterminalstate.md)

`IsTerminalState(OrderState orderState)`

## [Parameters](./isterminalstate.md)

**Parameter**

**Description**

**orderState**

The **OrderState** to compare

## [Examples](./isterminalstate.md)

```csharp
private Order entryOrder = null;
protected override void OnBarUpdate()
{
if (entryOrder == null && Close[0] > Open[0])
	EnterLongLimit(Close[0] - 1, "myEntryOrder");
}

protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled, double averageFillPrice, OrderState orderState, DateTime time, ErrorCode error, string nativeError)
if (entryOrder == null)

if (order.Name == "myEntryOrder" && !Order.IsTerminalState(order.OrderState))
	entryOrder = order;

if (entryOrder != null && entryOrder == order)
	if (Order.IsTerminalState(entryOrder.OrderState))
		entryOrder = null;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isterminalstate.md)
*   [Method Return Value](./isterminalstate.md)
*   [Syntax](./isterminalstate.md)
*   [Parameters](./isterminalstate.md)
*   [Examples](./isterminalstate.md)