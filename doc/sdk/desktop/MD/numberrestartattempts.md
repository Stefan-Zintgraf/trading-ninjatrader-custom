**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [NumberRestartAttempts](./numberrestartattempts.md)

# NumberRestartAttempts

# NumberRestartAttempts

## [Definition](./numberrestartattempts.md)

Determines the maximum number of restart attempts allowed within the last x minutes defined in **RestartsWithinMinutes** when the strategy experiences a connection loss. If restart attempts exceeds this property within a time span shorter than or equal to **RestartsWithinMinutes**, then the strategy will be stopped and no further attempts will occur. The purpose of these settings is to stop the strategy should your connection be unstable and incapable of maintaining a consistent connected state.

## [Property Value](./numberrestartattempts.md)

An **int** value represents the maximum number of restart attempts. Default value is set to 4.

## [Syntax](./numberrestartattempts.md)

`NumberRestartAttempts`

## [Examples](./numberrestartattempts.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         // Only allow the strategy to restart 4 times within the MaxRestartMinutes time span
         // If disconnected more than 4 times within that time span, stop the strategy and do not
         // attempt any further restarts.
         NumberRestartAttempts = 4;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./numberrestartattempts.md)
*   [Property Value](./numberrestartattempts.md)
*   [Syntax](./numberrestartattempts.md)
*   [Examples](./numberrestartattempts.md)