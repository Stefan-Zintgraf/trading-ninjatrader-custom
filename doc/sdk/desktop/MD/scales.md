**Path**: [ChartScale](./chartscale.md) > [Scales](./scales.md)

# Scales

# Scales

## [Definition](./scales.md)

A collection of **ChartScale** objects corresponding to objects within the chart panel.

## [Property Value](./scales.md)

A **ChartScaleCollection** containing **ChartScale** objects

## [Syntax](./scales.md)

`ChartPanel.Scales`

## [Examples](./scales.md)

```csharp

protected override void OnStateChange()
{
   if (State == State.Historical)
   {
     // loop through each panel which is currently configured on the hosting chart
     foreach (ChartPanel chartPanel in ChartControl.ChartPanels)
     {
         // there are multiple scale per panel
         // i.e., Right, Left, Overlay
         foreach (ChartScale scale in chartPanel.Scales)
         {
           // get the right scale margin type
           if (scale.ScaleJustification == ScaleJustification.Right)
           {
               Print(string.Format("The Right Scale of panel #{0}'s margin type is {1}",
                                   scale.PanelIndex, scale.Properties.AutoScaleMarginType));
           }
         }
     }
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
protected override void OnStateChange()
{
   if (State == State.Historical)
   {
       // Shows us at which index in the Scales collection the individual panel scales reside [0: Right, 1: Left, 2: Overlay]
       // The Scale collection gets accessed via passing the ScaleJustification enum in as index
       Print("Scales index " + 0 + " " + ChartPanel.Scales[ScaleJustification.Right]);
       Print("Scales index " + 1 + " " + ChartPanel.Scales[ScaleJustification.Left]);
       Print("Scales index " + 2 + " " + ChartPanel.Scales[ScaleJustification.Overlay]);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./scales.md)
*   [Property Value](./scales.md)
*   [Syntax](./scales.md)
*   [Examples](./scales.md)