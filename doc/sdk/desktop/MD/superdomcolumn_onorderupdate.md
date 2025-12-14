**Path**: [SuperDOM Column](./superdom_column.md) > [OnOrderUpdate()](./superdomcolumn_onorderupdate.md)

# OnOrderUpdate()

# OnOrderUpdate()

## [Definition](./superdomcolumn_onorderupdate.md)

Called every time an [order](./order.md) changes state. An order will change state when a change in order quantity, price or state (e.g. working to filled) occurs.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The OnOrderUpdate() method is called on ALL order updates (e.g., any account and instrument combination) and NOT just the specific items which are selected in the SuperDOM.

## [Method Return Value](./superdomcolumn_onorderupdate.md)

This method does not return a value.

## [Syntax](./superdomcolumn_onorderupdate.md)

`protected override void OnOrderUpdate(OrderEventArgs orderUpdate)`

## [Method Parameters](./superdomcolumn_onorderupdate.md)

Parameter

Description

## [Examples](./superdomcolumn_onorderupdate.md)

```csharp
protected override void OnOrderUpdate(OrderEventArgs orderUpdate)
{
  // Do not take action if the order update does not come from the selected SuperDOM instrument/account
  if (orderUpdate.Order.Instrument != SuperDom.Instrument || orderUpdate.Order.Account != SuperDom.Account)
    return;

  // Do something
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./superdomcolumn_onorderupdate.md)
*   [Method Return Value](./superdomcolumn_onorderupdate.md)
*   [Syntax](./superdomcolumn_onorderupdate.md)
*   [Method Parameters](./superdomcolumn_onorderupdate.md)
*   [Examples](./superdomcolumn_onorderupdate.md)