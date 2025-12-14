**Path**: [AddPlot()](./addplot.md) > [DisplayInDataBox](./displayindatabox.md)

# DisplayInDataBox

# DisplayInDataBox

## [Definition](./displayindatabox.md)

Determines if plot(s) display in the chart data box.

## [Property Value](./displayindatabox.md)

This property returns true if the indicator plot(s) values display in the chart data box; otherwise, false. Default set to true.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./displayindatabox.md)

`DisplayInDataBox`

## [Examples](./displayindatabox.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        DisplayInDataBox = false;   
        AddPlot(Brushes.Orange, "SMA");
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./displayindatabox.md)
*   [Property Value](./displayindatabox.md)
*   [Syntax](./displayindatabox.md)
*   [Examples](./displayindatabox.md)