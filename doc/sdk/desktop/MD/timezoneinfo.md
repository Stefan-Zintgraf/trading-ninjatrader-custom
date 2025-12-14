**Path**: [Trading Hours](./tradinghours.md) > [TimeZoneInfo](./timezoneinfo.md)

# TimeZoneInfo

# TimeZoneInfo

## [Definition](./timezoneinfo.md)

Indicates a time zone that is configured by a Trading Hours template

## [Property Value](./timezoneinfo.md)

A **TimeZoneInfo** object that represents the time zone for a configured Trading Hours template.

## [Syntax](./timezoneinfo.md)

`Bars.TradingHours.TimeZoneInfo`

## [Examples](./timezoneinfo.md)

```csharp
// Print the timezone before printing all sessions
Print(String.Format("All sessions are in {0}", Bars.TradingHours.TimeZoneInfo));

// Print details for all sessions in the Trading Hours template
for (int i = 0; i < TradingHours.Sessions.Count; i++)
{
   Print(String.Format("Session {0}: {1} at {2} to {3} at {4}", i, TradingHours.Sessions[i].BeginDay, TradingHours.Sessions[i].BeginTime,
     TradingHours.Sessions[i].EndDay, TradingHours.Sessions[i].EndTime));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./timezoneinfo.md)
*   [Property Value](./timezoneinfo.md)
*   [Syntax](./timezoneinfo.md)
*   [Examples](./timezoneinfo.md)