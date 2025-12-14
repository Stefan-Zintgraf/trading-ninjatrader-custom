**Path**: [Chart Style](./chart_style.md) > [DownBrush](./downbrush.md)

# DownBrush

# DownBrush

## [Definition](./downbrush.md)

A **Brush** object used to determine the color to paint the down bars for the ChartStyle.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This Windows Presentation Forms (WPF) implementation of the Brush class is not directly used to paint bars on the chart. Instead it is converted to a SharpDX Brush in the **DownBrushDX** property. This property is used to capture user input for changing brush colors.

## [Property Value](./downbrush.md)

A **WPF** Brush object used to paint the down bars.

## [Syntax](./downbrush.md)

`DownBrush`

## [Examples](./downbrush.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.Configure)
    {
        // Set a new name for the DownBrush property
        SetPropertyName("DownBrush", "DecliningBrush");
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./downbrush.md)
*   [Property Value](./downbrush.md)
*   [Syntax](./downbrush.md)
*   [Examples](./downbrush.md)