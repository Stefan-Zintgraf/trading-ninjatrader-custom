**Path**: [ChartAnchor](./chartanchor.md) > [IgnoresUserInput](./ignoresuserinput.md)

# IgnoresUserInput

# IgnoresUserInput

## [Definition](./ignoresuserinput.md)

Determines if the drawing tool can be clicked on by the user.

## [Property Value](./ignoresuserinput.md)

A bool value which wen true if the drawing tool cannot not be interacted with by a user; otherwise false. Default is set to false.

## [Syntax](./ignoresuserinput.md)

`IgnoresUserInput`

## [Examples](./ignoresuserinput.md)

```csharp

protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
           IgnoresUserInput = true; // Set this to true to make the drawing object non-interactive
     }
     else if (State == State.Configure)
     {

     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ignoresuserinput.md)
*   [Property Value](./ignoresuserinput.md)
*   [Syntax](./ignoresuserinput.md)
*   [Examples](./ignoresuserinput.md)