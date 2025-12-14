**Path**: [Unmanaged Approach](./unmanaged_approach.md) > [OrderFillResolution](./orderfillresolution.md)

# OrderFillResolution

# OrderFillResolution

## [Definition](./orderfillresolution.md)

Determines how strategy orders are filled during historical states.

Please see [Understanding Historical Fill Processing](https://ninjatrader.com/support/helpguides/nt8/?understanding_historical_fill_.htm) for general information on historical fill processing.

## [Property Value](./orderfillresolution.md)

An enum value that determines how the strategy orders are filled. Default value is set to **OrderFillResolution.Standard**. Possible values are:

*   **OrderFillResolution.Standard** \- Faster \- Uses the existing bar type and interval that you are running the backtest on to fill your orders.
    
*   **OrderFillResolution.High** \- More granular \- Allows you to set a secondary bar series to be used as the price data to fill your orders. (See also [OrderFillResolutionType](./orderfillresolutiontype.md) and [OrderFillResolutionValue](./orderfillresolutionvalue.md))
    

## [Syntax](./orderfillresolution.md)

`OrderFillResolution`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the [OnStateChange()](./onstatechange.md) method during State.SetDefaults

## [Examples](./orderfillresolution.md)

```csharp

protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Name = "ExampleStrategy";
     OrderFillResolution = OrderFillResolution.Standard;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./orderfillresolution.md)
*   [Property Value](./orderfillresolution.md)
*   [Syntax](./orderfillresolution.md)
*   [Examples](./orderfillresolution.md)