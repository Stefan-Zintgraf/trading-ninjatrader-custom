**Path**: [Account Class](./account_class.md) > [CreateOrder()](./createorder.md)

# CreateOrder()

# CreateOrder()

## [Definition](./createorder.md)

Creates an **Order** to be submitted via **Submit()**.

## [Syntax](./createorder.md)

`CreateOrder(Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, string oco, string name, DateTime gtd, CustomOrder customOrder)`

## [Parameters](./createorder.md)

**instrument**

Order instrument

**orderAction**

Possible values:

*   **OrderAction.Buy**
*   **OrderAction.BuyToCover**
*   **OrderAction.Sell**
*   **OrderAction.SellShort**

**orderType**

Possible values:

*   **OrderType.Limit**
*   **OrderType.Market**
*   **OrderType.MIT**
*   **OrderType.StopMarket**
*   **OrderType.StopLimit**

**orderEntry**

Possible values:

*   **OrderEntry.Automated**
*   **OrderEntry.Manual**

Allows setting the tag for orders submitted manually or via automated trading logic (CME tag 1028).

**timeInForce**

Possible values:

*   **TimeInForce.Day**
*   **TimeInForce.Gtc**
*   **TimeInForce.Gtd**
*   **TimeInForce.Ioc**
*   **TimeInForce.Opg**

**quantity**

Order quantity

**limitPrice**

Order limit price. Use "0" should this parameter be irrelevant for the OrderType being submitted.

**stopPrice**

Order stop price. Use "0" should this parameter be irrelevant for the OrderType being submitted.

**oco**

A string representing the OCO ID used to link OCO orders together

**name**

A string representing the name of the order. Max 50 characters.

Note: If using ATM Strategy **StartAtmStrategy()**, this value MUST be "Entry"

**gtd**

A **DateTime** value to be used with **TimeInForce.Gtd** \- for all other cases you can pass in **Core.Globals.MaxDate**

**customOrder**

Custom order if it is being used

## [Examples](./createorder.md)

```csharp
// Example code
Order stopOrder;
stopOrder = myAccount.CreateOrder(myInstrument, OrderAction.Sell, OrderType.StopMarket, OrderEntry.Automated, TimeInForce.Day, 1, 0, 1400, "myOCO", "stopOrder", Core.Globals.MaxDate, null);

myAccount.Submit(new[] { stopOrder });

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./createorder.md)
*   [Syntax](./createorder.md)
*   [Parameters](./createorder.md)
*   [Examples](./createorder.md)