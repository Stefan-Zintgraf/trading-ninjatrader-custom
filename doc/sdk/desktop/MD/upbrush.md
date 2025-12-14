**Path**: [Chart Style](./chart_style.md) > [UpBrush](./upbrush.md)

# UpBrush

# UpBrush

## [Definition](./upbrush.md)

A [Brush](https://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object used to determine the color to paint the up bars for the ChartStyle.

This Windows Presentation Forms (WPF) implementation of the Brush class is not directly used to paint bars on the chart. Instead it is converted to a SharpDX Brush in the [UpBrushDX](./upbrushdx.md) property. This property is used to capture user input for changing brush colors.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

## [Property  Value](./upbrush.md)

A [WPF](https://msdn.microsoft.com/en-us/library/ms754130(v=vs.110).aspx) Brush object used to paint the up bars

## [Syntax](./upbrush.md)

`UpBrush`

## [Examples](./upbrush.md)

```csharp
protected override void OnStateChange()  
{  
  if (State == State.Configure)  
  {  
      // Set a new name for the UpBrush property  
      SetPropertyName("UpBrush", "AdvancingBrush");  
  }  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./upbrush.md)
*   [Property  Value](./upbrush.md)
*   [Syntax](./upbrush.md)
*   [Examples](./upbrush.md)