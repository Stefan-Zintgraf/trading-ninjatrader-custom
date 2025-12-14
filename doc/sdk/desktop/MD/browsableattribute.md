**Path**: [Attributes](./attributes.md) > [BrowsableAttribute](./browsableattribute.md)

# BrowsableAttribute

# BrowsableAttribute

## [Definition](./browsableattribute.md)

Determines if the following declared property displays in the NinjaTrader UI's property grid. By default, all public properties in a NinjaScript object display, however this behavior can be changed by setting the Browsable attribute to false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The BrowsableAttribute object is a general purpose attribute made available from the .NET Framework. The information on this page is written to demonstrate how you may use this object within NinjaScript conventions used with the NinjaTrader UI's property grid (e.g., an indicator dialog). There are more methods and properties that you can learn about from MSDN's [BrowsableAttribute Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.browsableattribute(v=vs.110).aspx) which are NOT covered in this topic; as such there is NO guarantee they will work with the NinjaTrader UI's property grids.

## [Syntax](./browsableattribute.md)

`[Browsable(bool)]`

## [Parameters](./browsableattribute.md)

A bool which sets a value indicating if a property is browsable; default value is true

## [Examples](./browsableattribute.md)

```csharp
#region Properties

// do not show this value on the UI's property grid
[Browsable(false)]
public bool MyBool
{ get; set; }

# endregion

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./browsableattribute.md)
*   [Syntax](./browsableattribute.md)
*   [Parameters](./browsableattribute.md)
*   [Examples](./browsableattribute.md)