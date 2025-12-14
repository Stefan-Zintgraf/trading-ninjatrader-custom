**Path**: [ChartAnchor](./chartanchor.md) > [Dispose()](./dispose.md)

# Dispose()

# Dispose()

## [Definition](./dispose.md)

Releases any device resources used for the drawing tool.

## [Method Return Value](./dispose.md)

This method does not return a value.

## [Syntax](./dispose.md)

`Dispose()`

## [Method Parameters](./dispose.md)

This method does not accept any parameters.

## [Examples](./dispose.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Name                 = @"My Drawing Tool";
   }

   else if (State == State.Terminated)
     Dispose();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./dispose.md)
*   [Method Return Value](./dispose.md)
*   [Syntax](./dispose.md)
*   [Method Parameters](./dispose.md)
*   [Examples](./dispose.md)