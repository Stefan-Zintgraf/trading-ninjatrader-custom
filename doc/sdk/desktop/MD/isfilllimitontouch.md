**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [IsFillLimitOnTouch](./isfilllimitontouch.md)

# IsFillLimitOnTouch

# IsFillLimitOnTouch

## [Definition](./isfilllimitontouch.md)

Determines if the strategy will use a more liberal fill algorithm for back\-testing purposes only. The default behavior of the strategy's fill algorithm is to fill a limit order once price has penetrated the limit price. However, this behavior can be changed by setting **IsFillLimitOnTouch** to true, in which case the strategy's fill algorithm will consider a limit order filled once price has reached the limit price, but does not necessarily need to trade through the limit price.

## [Property Value](./isfilllimitontouch.md)

This property returns true if the strategy will fill limit orders when touched; otherwise, false. Default is set to false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults or State.Configure.

## [Syntax](./isfilllimitontouch.md)

`IsFillLimitOnTouch`

## [Examples](./isfilllimitontouch.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsFillLimitOnTouch = true;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isfilllimitontouch.md)
*   [Property Value](./isfilllimitontouch.md)
*   [Syntax](./isfilllimitontouch.md)
*   [Examples](./isfilllimitontouch.md)