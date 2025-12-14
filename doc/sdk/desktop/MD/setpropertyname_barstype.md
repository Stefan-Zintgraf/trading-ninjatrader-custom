**Path**: [Bars Type](./bars_type.md) > [SetPropertyName()](./setpropertyname_barstype.md)

# SetPropertyName()

# SetPropertyName()

## [Definition](./setpropertyname_barstype.md)

Sets a default property name to a custom string to be displayed on the UI.

## [Method Return Value](./setpropertyname_barstype.md)

This method does not return a value.

## [Syntax](./setpropertyname_barstype.md)

`SetPropertyName(string propertyName, string displayName)`

## [Method Parameters](./setpropertyname_barstype.md)

propertyName

A string representing the property to be renamed. Possible values include:

*   UpBrush
*   DownBrush
*   BarWidth
*   Stroke
*   Stroke2
*   Value
*   Value2
*   BaseBarsPeriodType
*   BaseBarsPeriodValue
*   PointAndFigurePriceType
*   ReversalType

displayName

A string representing the desired property name

## [Examples](./setpropertyname_barstype.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.Configure)
    {
        Properties.Remove(Properties.Find("Stroke", true));
        Properties.Remove(Properties.Find("Stroke2", true));

        SetPropertyName("UpBrush", "AdvanceBar");
        SetPropertyName("DownBrush", "DeclineBar");
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If you do not wish to use specific properties accessible via **SetPropertyName()**, you will need to remove them from the list via **Properties.Remove**, as shown in the example above.

#### ON THIS PAGE

*   [Definition](./setpropertyname_barstype.md)
*   [Method Return Value](./setpropertyname_barstype.md)
*   [Syntax](./setpropertyname_barstype.md)
*   [Method Parameters](./setpropertyname_barstype.md)
*   [Examples](./setpropertyname_barstype.md)