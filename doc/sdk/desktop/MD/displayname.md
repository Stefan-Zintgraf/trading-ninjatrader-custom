**Path**: [ChartAnchor](./chartanchor.md) > [DisplayName](./displayname.md)

# DisplayName

# DisplayName

## [Definition](./displayname.md)

Sets the display name prefix used for all properties for a chart anchor.

## [Property Value](./displayname.md)

A **string** value that is used to identify the name for a corresponding anchor. Default value is null.

## [Syntax](./displayname.md)

`<chartanchor>.DisplayName`

## [Examples](./displayname.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        MyAnchor = new ChartAnchor();
        MyAnchor.DisplayName = "MyChartAnchor";
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./displayname.md)
*   [Property Value](./displayname.md)
*   [Syntax](./displayname.md)
*   [Examples](./displayname.md)