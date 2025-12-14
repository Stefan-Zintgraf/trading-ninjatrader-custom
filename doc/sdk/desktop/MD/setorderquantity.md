**Path**: [PositionAccount](./positionaccount.md) > [SetOrderQuantity](./setorderquantity.md)

# SetOrderQuantity

# SetOrderQuantity

## [Definition](./setorderquantity.md)

Determines how order sizes are calculated for a given strategy.

## [Property Value](./setorderquantity.md)

An enum determining how order quantities are set. Default value is set to **SetOrderQuantity.Strategy**.

Possible values are:

Property

Description

**SetOrderQuantity.DefaultQuantity**

User defined order size based on the [DefaultQuantity](./defaultquantity.md) property

**SetOrderQuantity.Strategy**

Takes the order size specified programmatically within the strategy

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults or State.Configure.

## [Syntax](./setorderquantity.md)

`SetOrderQuantity`

## [Examples](./setorderquantity.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.Configure)
     {
         SetOrderQuantity = SetOrderQuantity.DefaultQuantity; // calculate orders based off default size
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./setorderquantity.md)
*   [Property Value](./setorderquantity.md)
*   [Syntax](./setorderquantity.md)
*   [Examples](./setorderquantity.md)