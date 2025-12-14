**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [DefaultQuantity](./defaultquantity.md)

# DefaultQuantity

# DefaultQuantity

## [Definition](./defaultquantity.md)

An order size variable that can be set either programmatically or overridden via the Strategy that determines the quantity of an entry order.

## [Property Value](./defaultquantity.md)

An **int** value represents the number of contracts or shares to enter a position with. Default value is 1.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./defaultquantity.md)

`DefaultQuantity`

## [Examples](./defaultquantity.md)

```csharp
protected override void OnStateChange() 
{
    if (State == State.SetDefaults)
    {
        DefaultQuantity = 1;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./defaultquantity.md)
*   [Property Value](./defaultquantity.md)
*   [Syntax](./defaultquantity.md)
*   [Examples](./defaultquantity.md)