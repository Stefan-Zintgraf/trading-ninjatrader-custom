**Path**: [SimpleFont](./simplefont.md) > [ApplyTo()](./applyto.md)

# ApplyTo()

# ApplyTo()

## [Definition](./applyto.md)

Applies a custom **SimpleFont** object's properties (family, size, and style) to a [Windows Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control?view=windowsdesktop-9.0&redirectedfrom=MSDN).

## [Method Return Value](./applyto.md)

This method does not return a value.

## [Syntax](./applyto.md)

`<simplefont>.ApplyTo(DependencyObject target)`

## [Parameters](./applyto.md)

Parameter

Description

target

The [DependencyObject](https://msdn.microsoft.com/en-us/library/system.windows.dependencyobject(v=vs.110).aspx) to apply the SimpleFont object

## [Examples](./applyto.md)

```csharp
// Define the custom button control object
System.Windows.Controls.Button myButton = new System.Windows.Controls.Button
{
    Name = "myButton",
    Content = "Buy",
    Foreground = Brushes.White,
    Background = Brushes.Green,
};

// Create a custom SimpleFont object and then apply it to the button
SimpleFont myFont = new SimpleFont("Consolas", 22);

myFont.ApplyTo(myButton);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./applyto.md)
*   [Method Return Value](./applyto.md)
*   [Syntax](./applyto.md)
*   [Parameters](./applyto.md)
*   [Examples](./applyto.md)