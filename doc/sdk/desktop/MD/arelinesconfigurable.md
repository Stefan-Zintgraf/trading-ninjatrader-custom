**Path**: [AddLine()](./addline.md) > [AreLinesConfigurable](./arelinesconfigurable.md)

# AreLinesConfigurable

# AreLinesConfigurable

## [Definition](./arelinesconfigurable.md)

Determines if the [line](./addline.md) used in an indicator are configurable from within the indicator dialog window.

## [Property Value](./arelinesconfigurable.md)

A **bool** which true if any indicator line(s) are configurable; otherwise, false. Default set to true.

## [Syntax](./arelinesconfigurable.md)

`AreLinesConfigurable`

## [Examples](./arelinesconfigurable.md)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Please note that in the following example, the indicator lines are not configurable.

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        AddLine(Brushes.Gray, 30, "Lower");
        AreLinesConfigurable = false; // Indicator lines are not configurable
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./arelinesconfigurable.md)
*   [Property Value](./arelinesconfigurable.md)
*   [Syntax](./arelinesconfigurable.md)
*   [Examples](./arelinesconfigurable.md)