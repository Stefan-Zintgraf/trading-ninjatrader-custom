**Path**: [Trading Hours](./tradinghours.md) > [DisplayName](./indicator_displayname.md)

# DisplayName

# DisplayName

## [Definition](./indicator_displayname.md)

Determines the text display on the chart panel. This is also listed in the UI as the "Label" which can be manually changed (if not overridden). The default behavior of this property will include the NinjaScript type Name along with its input and data series parameters. However this behavior can be overridden if desired.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For modifying the string which is used in the list of available indicators, please see the [Name](./name.md) property.

## [Property Value](./indicator_displayname.md)

A virtual string. This property is read\-only.

## [Syntax](./indicator_displayname.md)

`DisplayName`

You may choose to override this property using the following syntax:

```csharp
public override string DisplayName
{
  get { }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Examples](./indicator_displayname.md)

### Printing the default DisplayName which displays on the chart label

```csharp
protected override void OnStateChange()
{
  if (State == State.SetDefaults)
  {
    Name = "Example Indicator";
  }
}

protected override void OnBarUpdate()
{
  Print(DisplayName);   //Output:  Example Indicator(ES 03-15 (1 Minute))
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

### Overriding the DisplayName to customize the chart label

```csharp
protected override void OnStateChange()
{
  if (State == State.SetDefaults)
  {
    Name = "Example Indicator";
  }
}

public override string DisplayName
{
  get { return "My Custom Display " + Name; }
}

protected override void OnBarUpdate()
{
  Print(DisplayName);   //Output:  My Custom Display Example Indicator
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./indicator_displayname.md)
*   [Property Value](./indicator_displayname.md)
*   [Syntax](./indicator_displayname.md)
*   [Examples](./indicator_displayname.md)