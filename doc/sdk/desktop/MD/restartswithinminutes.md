**Path**: [PositionAccount](./positionaccount.md) > [RestartsWithinMinutes](./restartswithinminutes.md)

# RestartsWithinMinutes

# RestartsWithinMinutes

## [Definition](./restartswithinminutes.md)

Determines within how many minutes the strategy will attempt to restart. The strategy will only restart off a reestablished connection when there have been fewer restart attempts than **NumberRestartAttempts** in the last **NumberRestartAttempts** time span. The purpose of these settings is to stop the strategy should your connection be unstable and incapable of maintaining a consistent connected state.

## [Property Value](./restartswithinminutes.md)

An **int** value representing the maximum number of minutes in the time span in which restart attempts have to be less than **NumberRestartAttempts** for a strategy to be restarted when a connection is reestablished. Default value is set to 5.

## [Syntax](./restartswithinminutes.md)

`RestartsWithinMinutes`

## [Examples](./restartswithinminutes.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         /*Allow for restarting the strategy only if there were less restart attempts than
          MaxRestartAttempts within the last 5 minutes*/
         RestartsWithinMinutes = 5;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./restartswithinminutes.md)
*   [Property Value](./restartswithinminutes.md)
*   [Syntax](./restartswithinminutes.md)
*   [Examples](./restartswithinminutes.md)