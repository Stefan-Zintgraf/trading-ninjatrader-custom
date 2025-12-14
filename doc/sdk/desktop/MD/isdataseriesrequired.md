**Path**: [OnBarUpdate()](./onbarupdate.md) > [IsDataSeriesRequired](./isdataseriesrequired.md)

# IsDataSeriesRequired

# IsDataSeriesRequired

## [Definition](./isdataseriesrequired.md)

Determines if a Data Series is required for calculating this **NinjaScript** object. When set to false, data series related properties will not be displayed on the UI when configuring.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When set to false, methods and properties which are dependent on Bars will NOT be used. This means you will not receive any calls to **OnBarUpdate()** or be able to access historical bar prices.

## [Property Value](./isdataseriesrequired.md)

This property returns true if the **NinjaScript** requires a Data Series; otherwise, false. Default value is true.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./isdataseriesrequired.md)

`IsDataSeriesRequired`

## [Examples](./isdataseriesrequired.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsDataSeriesRequired = false;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isdataseriesrequired.md)
*   [Property Value](./isdataseriesrequired.md)
*   [Syntax](./isdataseriesrequired.md)
*   [Examples](./isdataseriesrequired.md)