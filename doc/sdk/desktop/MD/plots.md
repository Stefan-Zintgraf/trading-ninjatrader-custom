**Path**: [AddPlot()](./addplot.md) > [Plots](./plots.md)

# Plots

# Plots

## [Definition](./plots.md)

A collection holding all of the Plot objects that define their visualization characteristics.

## [Property Value](./plots.md)

A collection of Plot objects.

## [Syntax](./plots.md)

`Plots**[int index]`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The example code below will change the color of an entire plot series. See [PlotBrushes](./plotbrushes.md) for information on changing only specific segments of a plot instead.

## [Examples](./plots.md)

```csharp
protected override void OnStateChange()
{
   if(State == State.SetDefaults)
   {
       Name = "Examples Indicator";
       // Lines are added to the Lines collection in order
       AddPlot(Brushes.Orange, "Plot1"); // Stored in Plots[0]
       AddPlot(Brushes.Blue, "Plot2");   // Stored in Plots[1]
     }
}

// Dynamically change the primary plot's color based on the indicator value
protected override void OnBarUpdate()
{
   if (Value[0] > 70)
   {
     Plots[0].Brush = Brushes.Blue;
     Plots[0].Width = 2;
   }
   else
   {
     Plots[0].Brush = Brushes.Red;
     Plots[0].Width = 2;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./plots.md)
*   [Property Value](./plots.md)
*   [Syntax](./plots.md)
*   [Examples](./plots.md)