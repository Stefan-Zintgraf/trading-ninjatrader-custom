**Path**: [Rendering](./rendering.md) > [PanelUI](./panelui.md)

# PanelUI

# PanelUI

## [Definition](./panelui.md)

The zero\-based index of the chart panel in which the calling script is configured.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The "Panel" property configured in the Indicators or Strategies window on a chart is non\-zero\-based, while **PanelUI** is zero\-based. For example, if an indicator is configured in Panel # 1 in the Indicators window, **PanelUI** will return an index of 0. If the indicator were configured in Panel # 4 in the Indicators window, **PanelUI** would return an index of 3.

## [Property Value](./panelui.md)

An **int** value representing the panel the object is configured. This property is read\-only.

## [Syntax](./panelui.md)

`PanelUI`

## [Examples](./panelui.md)

```csharp
protected override void OnBarUpdate()
{
   // Print the zero-based panel index on which the script is configured
   Print("My object is on is on panel # " + **PanelUI**);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./panelui.md)
*   [Property Value](./panelui.md)
*   [Syntax](./panelui.md)
*   [Examples](./panelui.md)