**Path**: [ChartAnchor](./chartanchor.md) > [DisplayOnChartsMenus](./displayonchartsmenus.md)

# DisplayOnChartsMenus

# DisplayOnChartsMenus

## [Definition](./displayonchartsmenus.md)

Determines if the drawing tool displays in the chart's drawing tool menus.

## [Property Value](./displayonchartsmenus.md)

A bool value, when true the drawing tool will be created on the chart's drawing tool menu; otherwise false. Default value is true.

## [Syntax](./displayonchartsmenus.md)

`DisplayOnChartsMenus`

## [Examples](./displayonchartsmenus.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Name                 = @"My Drawing Tool";
     DisplayOnChartsMenus = true;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./displayonchartsmenus.md)
*   [Property Value](./displayonchartsmenus.md)
*   [Syntax](./displayonchartsmenus.md)
*   [Examples](./displayonchartsmenus.md)