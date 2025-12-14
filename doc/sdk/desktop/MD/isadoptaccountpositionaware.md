**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [IsAdoptAccountPositionAware](./isadoptaccountpositionaware.md)

# IsAdoptAccountPositionAware

# IsAdoptAccountPositionAware

## [Definition](./isadoptaccountpositionaware.md)

Determines if the strategy is programmed in a manner capable of handling real\-world account positions. Once set to true, your strategy's **Start behavior** options will include an additional parameter named **Adopt account position** which can be set at run\-time. Only set to true if you have specifically programmed your strategy to be able to adopt account positions.

## [Property Value](./isadoptaccountpositionaware.md)

This property returns true if the strategy can adopt account positions; otherwise, false. Default is set to false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults.

## [Syntax](./isadoptaccountpositionaware.md)

`IsAdoptAccountPositionAware`

## [Examples](./isadoptaccountpositionaware.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsAdoptAccountPositionAware = true;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isadoptaccountpositionaware.md)
*   [Property Value](./isadoptaccountpositionaware.md)
*   [Syntax](./isadoptaccountpositionaware.md)
*   [Examples](./isadoptaccountpositionaware.md)