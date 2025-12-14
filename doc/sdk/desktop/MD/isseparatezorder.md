**Path**: [ChartScale](./chartscale.md) > [IsSeparateZOrder](./isseparatezorder.md)

# IsSeparateZOrder

# IsSeparateZOrder

## [Definition](./isseparatezorder.md)

Determines the [ZOrder](./chart_zorder.md) of the drawing object will be different than the NinjaScript object that drew it.  When false the drawing object will share the same ZOrder.

## [Property Value](./isseparatezorder.md)

This property returns true if the object is drawn on a separate ZOrder; otherwise, false. Default set to false.

## [Syntax](./isseparatezorder.md)

`IsSeparateZOrder`

## [Example](./isseparatezorder.md)

```csharp
protected override void OnBarUpdate()  
{  
  // Instantiate a Dot object  
  Dot myDot = Draw.Dot(this, "NewDot", true, 5, High[5], Brushes.Black);  
   
  // Set the Dot object to use a separate Z-Order than the indicator that created it  
  myDot.IsSeparateZOrder = true;  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isseparatezorder.md)
*   [Property Value](./isseparatezorder.md)
*   [Syntax](./isseparatezorder.md)
*   [Example](./isseparatezorder.md)