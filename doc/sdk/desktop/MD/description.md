**Path**: [Trading Hours](./tradinghours.md) > [Description](./description.md)

# Description

# Description

## [Definition](./description.md)

Text which is used on the UI's information box to be displayed to a user when configuring a **NinjaScript** object.

## [Method Return Value](./description.md)

A **string** value representing text used to describe the object.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./description.md)

`Description`

## [Examples](./description.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Name = "Examples Indicator";
     Description = @"An indicator used to demonstrate various NinjaScript methods and properties";
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./description.md)
*   [Method Return Value](./description.md)
*   [Syntax](./description.md)
*   [Examples](./description.md)