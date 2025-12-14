**Path**: [ChartAnchor](./chartanchor.md) > [Icon](./icon_drawingtool.md)

# Icon

# Icon

## [Definition](./icon_drawingtool.md)

The shape which displays next to the Drawing Tool menu item. Since this is a standard object, any type of icon can be used (unicode characters, custom image file resource, geometry path, etc). For more information on using images to create icons, see the [Using Images with Custom Icons](./using_images_and_geometry_with_custom_icons.md).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When using **UniCode** characters, first ensure that the desired characters exist in the icon pack for the font family used in **NinjaTrader**.

## [Property Value](./icon_drawingtool.md)

A generic virtual object representing the drawing tools menu icon. This property is read\-only.

## [Syntax](./icon_drawingtool.md)

You must override this property using the following syntax:

`public override object Icon`

## [Examples](./icon_drawingtool.md)

```csharp
public override object Icon
{         
   get 
   {
     //use a unicode character as our string which will render an arrow
     string uniCodeArrow = "\u279A";             
     return uniCodeArrow; 
   }   
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./icon_drawingtool.md)
*   [Property Value](./icon_drawingtool.md)
*   [Syntax](./icon_drawingtool.md)
*   [Examples](./icon_drawingtool.md)