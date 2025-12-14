**Path**: [AddLine()](./addline.md) > [Lines](./lines.md)

# Lines

# Lines

## [Definition](./lines.md)

A collection holding all of the Line objects that define the visualization characteristics oscillator lines of the indicator.

## [Property Value](./lines.md)

A collection of Line objects.

## [Syntax](./lines.md)

`Lines[int index]`

## [Examples](./lines.md)

```csharp

protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         // Lines are added to the Lines collection in order
         AddLine(Brushes.Gray, 30, "Lower"); // Stored in Lines[0]
         AddLine(Brushes.Gray, 70, "Upper"); // Stored in Lines[1]
     }
}
// Dynamically change the upper line's color and thickness based on the indicator value
protected override void OnBarUpdate()
{
   if (Value[0] > 70)
   {
     Lines[1].Brush = Brushes.Blue;
     Lines[1].Width = 3;
   }
   else
   {
     Lines[1].Brush = Brushes.Gray;
     Lines[1].Width = 1;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./lines.md)
*   [Property Value](./lines.md)
*   [Syntax](./lines.md)
*   [Examples](./lines.md)