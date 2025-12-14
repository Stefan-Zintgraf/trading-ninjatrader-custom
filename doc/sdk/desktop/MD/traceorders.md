**Path**: [SystemPerformance](./systemperformance.md) > [TraceOrders](./traceorders.md)

# TraceOrders

# TraceOrders

## [Definition](./traceorders.md)

Determines if **OnOrderTrace()** would be called for a given strategy. When enabled, traces are generated and displayed in the [NinjaScript Output](https://ninjatrader.com/support/helpGuides/nt8/?output.htm) window for each call of an **order method** providing confirmation that the method is entered and providing information if order methods are ignored and why. This is valuable for debugging if you are not seeing expected behavior when calling an order method. This property can be set programmatically in the **OnStateChange()** method.

The output will reference a method **PlaceOrder()** which is an internal method that all **Enter()** and **Exit()** methods use.

## [Property Value](./traceorders.md)

This property returns true if the strategy will output trace information; otherwise, false. Default value is false.

## [Syntax](./traceorders.md)

`TraceOrders`

## [Examples](./traceorders.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         TraceOrders = true;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tips

1.  See [this](./traceorders2.md) article for more examples of how to utilize this property.
2.  You can override the default output by using **OnOrderTrace()** in your strategy.

#### ON THIS PAGE

*   [Definition](./traceorders.md)
*   [Property Value](./traceorders.md)
*   [Syntax](./traceorders.md)
*   [Examples](./traceorders.md)