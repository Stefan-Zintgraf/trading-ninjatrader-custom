**Path**: [AddPlot()](./addplot.md) > [PlotBrushes](./plotbrushes.md)

# PlotBrushes

# PlotBrushes

## [Definition](./plotbrushes.md)

Holds an array of color series objects holding historical bar colors. A color series object is added to this array when calling the **AddPlot()** method in a custom Indicator for plots. Its purpose is to provide access to the color property of all bars.

## [Property Value](./plotbrushes.md)

An array of color series objects.

## [Syntax](./plotbrushes.md)

`PlotBrushes[int PlotIndex][int barsAgo]`

## [Examples](./plotbrushes.md)

```csharp
protected override void OnStateChange()
{
   if(State == State.SetDefaults)
   {
     Name = "Example Indicator";   
       // Add two plots
       AddPlot(Brushes.Blue, "Upper");
       AddPlot(Brushes.Orange, "Lower");
     }
}
 
protected override void OnBarUpdate()
{
     // Sets values to our two plots
     Upper[0] = SMA(High, 20)[0];
     Lower[0] = SMA(Low, 20)[0];

     // Color the Upper plot based on plot value conditions
     if (IsRising(Upper))
         PlotBrushes[0][0] = Brushes.Blue;
     else if (IsFalling(Upper))
         PlotBrushes[0][0] = Brushes.Red;
     else
         PlotBrushes[0][0] = Brushes.Yellow;
 
     // Color the Lower plot based on plot value conditions
     if (IsRising(Lower))
         PlotBrushes[1][0] = Brushes.Blue;
     else if (IsFalling(Lower))
         PlotBrushes[1][0] = Brushes.Red;
     else
         PlotBrushes[1][0] = Brushes.Yellow;
}

public Series<double> Upper
{
    get { return Values[0]; }
}

public Series<double> Lower
{
    get { return Values[1]; }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./plotbrushes.md)
*   [Property Value](./plotbrushes.md)
*   [Syntax](./plotbrushes.md)
*   [Examples](./plotbrushes.md)