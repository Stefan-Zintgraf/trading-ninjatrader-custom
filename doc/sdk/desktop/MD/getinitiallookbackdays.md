**Path**: [Bars Type](./bars_type.md) > [GetInitialLookBackDays()](./getinitiallookbackdays.md)

# GetInitialLookBackDays()

# GetInitialLookBackDays()

## [Definition](./getinitiallookbackdays.md)

Determines how many days of data load when a user makes a "bars back" data request.

## [Method Return Value](./getinitiallookbackdays.md)

This method returns An **int** value.

## [Method Parameters](./getinitiallookbackdays.md)

**barsPeriod**

The [bars period](./barsperiod.md) chosen by the user when utilizing this Bars type

**tradingHours**

The [trading hours](./tradinghours.md) chosen by the user when utilizing this Bars type

**barsBack**

The bars back chosen by the user when utilizing this Bars type

## [Syntax](./getinitiallookbackdays.md)

You must override the method in your Bars Type with the following syntax.

`public override int GetInitialLookBackDays(BarsPeriod barsPeriod, TradingHours tradingHours, int barsBack) { }`

## [Examples](./getinitiallookbackdays.md)

```csharp
public override int GetInitialLookBackDays(BarsPeriod barsPeriod, TradingHours tradingHours, int barsBack)
{
     // Returns the minimum number of days needed to successfully load the number
     // of bars back requested for a monthly Bars type
     return (int) barsPeriod.Value * barsBack * 31;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tip: Try to request an amount of data that is just right for what is needed. Requesting too large a data set will result in unnecessary data being loaded. Requesting too small a data set will result in multiple requests being done.

#### ON THIS PAGE

*   [Definition](./getinitiallookbackdays.md)
*   [Method Return Value](./getinitiallookbackdays.md)
*   [Method Parameters](./getinitiallookbackdays.md)
*   [Syntax](./getinitiallookbackdays.md)
*   [Examples](./getinitiallookbackdays.md)