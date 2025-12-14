**Path**: [Drawing](./drawing.md) > [BackBrushes](./backbrushes.md)

# BackBrushes

# BackBrushes

## [Definition](./backbrushes.md)

A collection of prior back brushes used for the background colors of the chart panel.

## [Property Value](./backbrushes.md)

A brush series type object. Accessing this property via an index value `[int barsAgo]` returns a **Brush** object representing the color of the background color on the referenced bar.

## [Syntax](./backbrushes.md)

`BackBrushes`

`BackBrushes[int barsAgo]`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

You may have up to 65,535 unique BackBrushes instances, therefore, using [static predefined brushes](./working_with_brushes.md) should be favored. Alternatively, in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created.

## [Examples](./backbrushes.md)

```csharp
protected override void OnBarUpdate()
{
    if (CurrentBar < 1)
        return;

    // Sets the color of the background on the current bar as blue
    BackBrushes[0] = Brushes.Blue;

    // Sets the color of the background on the previous bar as orange
    BackBrushes[1] = Brushes.Orange;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./backbrushes.md)
*   [Property Value](./backbrushes.md)
*   [Syntax](./backbrushes.md)
*   [Examples](./backbrushes.md)