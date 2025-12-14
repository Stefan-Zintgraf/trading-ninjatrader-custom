**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [DisconnectDelaySeconds](./disconnectdelayseconds.md)

# DisconnectDelaySeconds

# DisconnectDelaySeconds

## [Definition](./disconnectdelayseconds.md)

Determines the amount of time a disconnect would have to last before **connection loss handling** takes action.

## [Property Value](./disconnectdelayseconds.md)

An **int** value represents the time required for a disconnect to last before connection loss handling actions will occur. Default value is 10.

## [Syntax](./disconnectdelayseconds.md)

`DisconnectDelaySeconds`

## [Examples](./disconnectdelayseconds.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         // Disconnect has to be at least 10 seconds
         DisconnectDelaySeconds = 10;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./disconnectdelayseconds.md)
*   [Property Value](./disconnectdelayseconds.md)
*   [Syntax](./disconnectdelayseconds.md)
*   [Examples](./disconnectdelayseconds.md)