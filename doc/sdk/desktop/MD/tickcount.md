**Path**: [Bars](./bars.md) > [TickCount](./tickcount.md)

# TickCount

# TickCount

## [Definition](./tickcount.md)

Returns the total number of ticks of the current bar processing.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For historical usage, you must use **Calculate.OnEachTick** with [**TickReplay**](./developing_for_tick_replay.md) enabled; otherwise a value of 1 will be returned.

## [Property Value](./tickcount.md)

A long value that represents the total number of ticks of the current bar.

## [Syntax](./tickcount.md)

`Bars.TickCount`

## [Examples](./tickcount.md)

```csharp
// Prints the tick count to the output window
Print("The tick count of the current bar is " + **Bars.TickCount**.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./tickcount.md)
*   [Property Value](./tickcount.md)
*   [Syntax](./tickcount.md)
*   [Examples](./tickcount.md)