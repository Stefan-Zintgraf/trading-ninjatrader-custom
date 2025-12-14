**Path**: [ChartAnchor](./chartanchor.md) > [ZOrderType](./zordertype.md)

# ZOrderType

# ZOrderType

## [Definition](./zordertype.md)

Determines the order in which sthe drawing tool will be rendered. This will help control the [ZOrder](./chart_zorder.md) index between chart objects

## [Property Value](./zordertype.md)

An enum determining the drawing tool's ZOrder type.  Possible values are:

Name

Description

**DrawingToolZOrder.Normal**

Default behavior, drawing tools are rendered as they appear in the [ZOrder](./chart_zorder.md) index

**DrawingToolZOrder.AlwaysDrawnFirst**

Ensures the drawing tool is always the first to be rendered

**DrawingToolZOrder.AlwaysDrawnLast**

Ensures the drawing tool is always the last object to be rendered

## [Syntax](./zordertype.md)

`ZOrderType`

## [Examples](./zordertype.md)

```csharp
protected override void OnStateChange()  
{  
  if (State == State.SetDefaults)  
  {  
    Name               = @"My Drawing Tool";  
           
    // always draw this last  
    ZOrderType           = DrawingToolZOrder.AlwaysDrawnLast;  
  }  
  else if (State == State.Configure)  
  {  
  }  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./zordertype.md)
*   [Property Value](./zordertype.md)
*   [Syntax](./zordertype.md)
*   [Examples](./zordertype.md)