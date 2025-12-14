**Path**: [Chart Style](./chart_style.md) > [IsTransparent](./istransparent.md)

# IsTransparent

# IsTransparent

## [Definition](./istransparent.md)

Indicates the bars in the ChartStyle are transparent.

## [Property Value](./istransparent.md)

A bool which, when true, indicates that the **UpBrush**, **DownBrush**, and **Stroke.Brush** are all set to transparent. Returns false if any of the three are not transparent.

## [Syntax](./istransparent.md)

`IsTransparent`

## [Examples](./istransparent.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.Configure)
   {
       //Print a message if the UpBrush, DownBrush, and Stroke.Brush are all transparent
       if (IsTransparent)
           Print("All bars are currently set to transparent");
   }
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./istransparent.md)
*   [Property Value](./istransparent.md)
*   [Syntax](./istransparent.md)
*   [Examples](./istransparent.md)