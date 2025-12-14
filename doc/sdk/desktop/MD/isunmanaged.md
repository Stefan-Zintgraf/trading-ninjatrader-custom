**Path**: [Unmanaged Approach](./unmanaged_approach.md) > [IsUnmanaged](./isunmanaged.md)

# IsUnmanaged

# IsUnmanaged

## [Definition](./isunmanaged.md)

Determines if the strategy will be using Unmanaged order methods.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Unmanaged order methods and **Managed order methods** cannot be used interchangeably. When **IsUnmanaged** is set to true, calling managed order methods such as **EnterLong()**, **SetStopLoss()**, etc., will generate an error which will be displayed on the **Log tab** of the Control Center.

## [Property Value](./isunmanaged.md)

This property returns true if the strategy will use Unmanaged order methods; otherwise, false. Default is set to false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./isunmanaged.md)

`IsUnmanaged`

## [Examples](./isunmanaged.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Use Unmanaged order methods
        IsUnmanaged = true;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isunmanaged.md)
*   [Property Value](./isunmanaged.md)
*   [Syntax](./isunmanaged.md)
*   [Examples](./isunmanaged.md)