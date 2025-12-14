**Path**: [Unmanaged Approach](./unmanaged_approach.md) > [OrderFillResolutionType](./orderfillresolutiontype.md)

# OrderFillResolutionType

# OrderFillResolutionType

## [Definition](./orderfillresolutiontype.md)

Determines the bars type which will be used for historical fill processing.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property will only be valid if the **OrderFillResolution** is set to **OrderFillResolution.High**.

## [Property Value](./orderfillresolutiontype.md)

A **BarsPeriodType** representing the type of bars during historical order processing. Default value is set to **BarsPeriodType.Minute**.

## [Syntax](./orderfillresolutiontype.md)

`OrderFillResolutionType`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the `OnStateChange()` method during **State.SetDefaults**.

## [Examples](./orderfillresolutiontype.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {                
        Name = "ExampleStrategy";

        // use one second bars for filling orders
        OrderFillResolution       = OrderFillResolution.High;                 
        OrderFillResolutionType   = BarsPeriodType.Second;
        OrderFillResolutionValue   = 1; 
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./orderfillresolutiontype.md)
*   [Property Value](./orderfillresolutiontype.md)
*   [Syntax](./orderfillresolutiontype.md)
*   [Examples](./orderfillresolutiontype.md)