**Path**: [AddPlot()](./addplot.md) > [IsChartOnly](./ischartonly.md)

# IsChartOnly

# IsChartOnly

## [Definition](./ischartonly.md)

If true, any indicator will be only available for charting usage \- indicators with this property enabled would for example not be expected to show if called in a SuperDOM or MarketAnalyzer window.

## [Property Value](./ischartonly.md)

This property returns true if the indicator can only be used on a chart; otherwise, false. Default set to false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./ischartonly.md)

`IsChartOnly`

## [Examples](./ischartonly.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsChartOnly = true; // Allow the indicator to work in charting environment only       
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ischartonly.md)
*   [Property Value](./ischartonly.md)
*   [Syntax](./ischartonly.md)
*   [Examples](./ischartonly.md)