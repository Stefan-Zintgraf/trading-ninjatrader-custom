**Path**: [TimeSeries<datetime>](./timeseries.md) > [Time](./time.md)

# Time

# Time

## [Definition](./time.md)

A collection of historical bar time stamp values.

## [Property Value](./time.md)

An **ISeries<`datetime`\>** object.

## [Syntax](./time.md)

`Time`

**Returns a DateTime structure**

`Time[int barsAgo]`

## [Examples](./time.md)

```csharp
// Prints the current bar time stamp
Print(Time[0].ToString());

//Checks if current time is greater than the bar time stamp
if (DateTime.Now.Ticks > Time[0].Ticks)
 Print("Do something");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./time.md)
*   [Property Value](./time.md)
*   [Syntax](./time.md)
*   [Examples](./time.md)