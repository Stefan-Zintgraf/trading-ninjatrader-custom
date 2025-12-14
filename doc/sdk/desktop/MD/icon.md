**Contexts**:
- [Chart Style](./chart_style.md) > [Icon](./icon.md)
- [Share Service](./share_service.md) > [Icon](./icon.md)

# Icon

# Icon

## [Definition](./icon.md)

The shape which displays within the Share window when sharing content. Since this is a standard object, any type of icon can be used (unicode characters, custom image file resource, geometry path, etc). For more information on using images to create icons, see the [Using Images with Custom Icons](./using_images_and_geometry_with_custom_icons.md).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When using Unicode characters, first ensure that the desired characters exist in the icon pack for the font family used in NinjaTrader.

## [Property Value](./icon.md)

A generic virtual object representing the drawing tools menu icon. This property is read\-only.

## [Syntax](./icon.md)

You must override this property using the following syntax:

`public override object Icon`

## [Examples](./icon.md)

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

*   [Definition](./icon.md)
*   [Property Value](./icon.md)
*   [Syntax](./icon.md)
*   [Examples](./icon.md)