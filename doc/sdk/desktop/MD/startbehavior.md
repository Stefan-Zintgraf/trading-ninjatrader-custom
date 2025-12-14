**Path**: [PositionAccount](./positionaccount.md) > [StartBehavior](./startbehavior.md)

# StartBehavior

# StartBehavior

## [Definition](./startbehavior.md)

Sets the start behavior of the strategy. See [Syncing Account Positions](https://ninjatrader.com/support/helpguides/nt8/?syncing_account_positions.htm) for more information.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In order to use **AdoptAccountPosition** you will need to first set [**IsAdoptAccountPositionAware**](./isadoptaccountpositionaware.md) to true. Please be sure that your strategy is specifically programmed in a manner that can accommodate account positions before using this mode.

## [Property Value](./startbehavior.md)

An enum value that determines how the strategy behaves; Default value is set to **StartBehavior.WaitUntilFlat**. Possible values are:

*   **StartBehavior.AdoptAccountPosition**
*   **StartBehavior.ImmediatelySubmit**
*   **StartBehavior.ImmediatelySubmitSynchronizeAccount**
*   **StartBehavior.WaitUntilFlat**
*   **StartBehavior.WaitUntilFlatSynchronizeAccount**

## [Syntax](./startbehavior.md)

`StartBehavior`

## [Examples](./startbehavior.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         StartBehavior = StartBehavior.WaitUntilFlat;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./startbehavior.md)
*   [Property Value](./startbehavior.md)
*   [Syntax](./startbehavior.md)
*   [Examples](./startbehavior.md)