**Path**: [Account Class](./account_class.md) > [Submit()](./submit.md)

# Submit()

# Submit()

## [Definition](./submit.md)

Submits specified **Order** object(s).

## [Syntax](./submit.md)

`Submit(IEnumerable<`order`> orders)`

## [Parameters](./submit.md)

**orders**

Order(s) to submit

## [Examples](./submit.md)

```csharp
Order stopOrder = null;  
stopOrder = myAccount.CreateOrder(myInstrument, OrderAction.Sell, OrderType.StopMarket, TimeInForce.Day, 1, 0, 1400, "myOCO", "stopOrder", null);  
myAccount.Submit(new[] { stopOrder });

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./submit.md)
*   [Syntax](./submit.md)
*   [Parameters](./submit.md)
*   [Examples](./submit.md)