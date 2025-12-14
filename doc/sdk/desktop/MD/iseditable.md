**Path**: [Market Analyzer Column](./market_analyzer_column.md) > [IsEditable](./iseditable.md)

# IsEditable

# IsEditable

## [Definition](./iseditable.md)

Determines if a Market Analyzer Column is editable.

## [Property Value](./iseditable.md)

This property returns true if the Market Analyzer Column can be edited; otherwise, false.

## [Syntax](./iseditable.md)

`IsEditable`

## [Examples](./iseditable.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        DataType = typeof(string);
        IsEditable = true;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./iseditable.md)
*   [Property Value](./iseditable.md)
*   [Syntax](./iseditable.md)
*   [Examples](./iseditable.md)