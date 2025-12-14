**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [IsWaitUntilFlat](./iswaituntilflat.md)

# IsWaitUntilFlat

# IsWaitUntilFlat

## [Definition](./iswaituntilflat.md)

Indicates the strategy is currently waiting until a flat position is detected before submitting live orders.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property would only apply if the strategy **StartBehavior** was set to **StartBehavior.WaitUntilFlat** or **StartBehavior.WaitUntilFlatSynchronizeAccount**.

## [Property Value](./iswaituntilflat.md)

This property returns true if the strategy has detected it is either in a long or short position during **State.Transition**; otherwise false. Default value is set to false.

## [Syntax](./iswaituntilflat.md)

`IsWaitUntilFlat`

## [Examples](./iswaituntilflat.md)

```csharp
// If a strategy is waiting for a flat position, return and print a message
if (!IsWaitUntilFlat)
{ 
   Print("This strategy is currently waiting for a flat account position to begin placing trades");
   return;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./iswaituntilflat.md)
*   [Property Value](./iswaituntilflat.md)
*   [Syntax](./iswaituntilflat.md)
*   [Examples](./iswaituntilflat.md)