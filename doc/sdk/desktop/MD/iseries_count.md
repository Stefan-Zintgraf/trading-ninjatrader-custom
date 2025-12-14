**Path**: [ISeries](./iseriest.md) > [Count](./iseries_count.md)

# Count

# Count

## [Definition](./iseries_count.md)

Indicates the number total number of values in the **ISeries** array. This value should always be in sync with the [**CurrentBars**](./currentbars.md) array for that series.

## [Method Return Value](./iseries_count.md)

A **int** representing the total size of the series.

## [Syntax](./iseries_count.md)

`Count`

## [Examples](./iseries_count.md)

```csharp
protected override void OnBarUpdate()
{
    Print("Input count: " + Input.Count);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./iseries_count.md)
*   [Method Return Value](./iseries_count.md)
*   [Syntax](./iseries_count.md)
*   [Examples](./iseries_count.md)