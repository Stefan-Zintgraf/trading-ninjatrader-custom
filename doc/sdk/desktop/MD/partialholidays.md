**Path**: [Trading Hours](./tradinghours.md) > [PartialHolidays](./partialholidays.md)

# PartialHolidays

# PartialHolidays

## [Definition](./partialholidays.md)

A collection of partial holidays which are configured for a Trading Hours template. Holidays are days which fall outside of the normal trading schedule, on which data will be excluded. For more information please see the "Understanding trading holidays" section of the [Using the Trading Hours](https://ninjatrader.com/support/helpGuides/nt8/?using_the_trading_hours_window.htm) window.

## [Property Value](./partialholidays.md)

A **Dictionary** holding a collection of holiday Dates and **PartialHoliday** objects for each partial holiday.

Date

PartialHoliday

A DateTime representing the trading date of the Trading Hours holiday

An object containing a DateTime representing the date of the early close or late begin, a description of the partial holiday, and two bool properties, **IsEarlyClose** and **IsLateBegin**

## [Syntax](./partialholidays.md)

`TradingHours.PartialHolidays`

## [Examples](./partialholidays.md)

```csharp
// Print all partial holidays included in the Bars object's Trading Hours template
foreach(KeyValuePair<datetime, partialholiday> holiday in TradingHours.PartialHolidays)
{
    Print(holiday);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./partialholidays.md)
*   [Property Value](./partialholidays.md)
*   [Syntax](./partialholidays.md)
*   [Examples](./partialholidays.md)