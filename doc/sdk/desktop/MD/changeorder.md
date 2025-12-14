**Path**: [Managed Approach](./managed_approach.md) > [ChangeOrder()](./changeorder.md)

# ChangeOrder()

# ChangeOrder()

## [Definition](./changeorder.md)

Amends a specified **Order**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method is only relevant for Managed orders with IsLiveUntilCancelled set to true and Unmanaged orders.

## [Syntax](./changeorder.md)

`ChangeOrder(Order order, int quantity, double limitPrice, double stopPrice)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

If you have existing historical `order` references which have transitioned to real\-time, you MUST update the order object reference to the newly submitted real\-time order; otherwise errors may occur as you attempt to change the order. You may use the `GetRealtimeOrder()` helper method to assist in this transition.

## [Parameters](./changeorder.md)

order

**Order object** of the order you wish to amend

quantity

Order quantity

limitPrice

Order limit price. Use "0" should this parameter be irrelevant for the OrderType being submitted.

stopPrice

Order stop price. Use "0" should this parameter be irrelevant for the OrderType being submitted.

## [Examples](./changeorder.md)

```csharp
private Order stopOrder = null;

protected override void OnBarUpdate()
{
    // Raise stop loss to breakeven when you are at least 4 ticks in profit
    if (stopOrder != null && stopOrder.StopPrice < Position.AveragePrice && Close[0] >= Position.AveragePrice + 4 * TickSize)
        ChangeOrder(stopOrder, stopOrder.Quantity, 0, Position.AveragePrice);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./changeorder.md)
*   [Syntax](./changeorder.md)
*   [Parameters](./changeorder.md)
*   [Examples](./changeorder.md)