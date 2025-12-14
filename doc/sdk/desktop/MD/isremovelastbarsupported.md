**Path**: [Bars Type](./bars_type.md) > [IsRemoveLastBarSupported](./isremovelastbarsupported.md)

# IsRemoveLastBarSupported

# IsRemoveLastBarSupported

## [Definition](./isremovelastbarsupported.md)

Determines if the bars type can use the **RemoveLastBar()** method when true, otherwise an exception will be thrown. Bar Types which use remove last bar concepts CANNOT be used with **Tick Replay**, and as a result Tick Replay will be disabled on the UI when **IsRemoveLastBarSupported** is set to true.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property is read\-only, but may be overridden in a custom bar type.

## [Syntax](./isremovelastbarsupported.md)

`IsRemoveLastBarSupported`

## [Property value](./isremovelastbarsupported.md)

A **bool** determining if the BarsType can remove the last; default value is false.

## [Examples](./isremovelastbarsupported.md)

```csharp
// allows RemoveLastBar() to be called
public override bool IsRemoveLastBarSupported { get { return true; } }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isremovelastbarsupported.md)
*   [Syntax](./isremovelastbarsupported.md)
*   [Property value](./isremovelastbarsupported.md)
*   [Examples](./isremovelastbarsupported.md)