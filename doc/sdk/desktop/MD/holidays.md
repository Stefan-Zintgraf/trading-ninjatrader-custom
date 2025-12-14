**Path**: [Trading Hours](./tradinghours.md) > [Holidays](./holidays.md)

# Holidays

# Holidays

## [Definition](./holidays.md)

A collection of full holidays configured for a Trading Hours template. Holidays are days which fall outside of the regular trading schedule.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For more information please see the "Understanding trading holidays" section of the [Using the Trading Hours](https://ninjatrader.com/support/helpGuides/nt8/?using_the_trading_hours_window.htm) window.

## [Property Value](./holidays.md)

A **Dictionary** holding a collection of holiday Dates and Descriptions of each holiday.

Date

Description

A **DateTime** representing the date of the trading hours holiday

A string which is used to describe the holiday (e.g., Christmas)

## [Syntax](./holidays.md)

`TradingHours.Holidays`

## [Examples](./holidays.md)

```csharp
// Print all holidays included in the Bars object's Trading Hours template
foreach(KeyValuePair<datetime, string> holiday in TradingHours.Holidays)
{
    Print(holiday);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./holidays.md)
*   [Property Value](./holidays.md)
*   [Syntax](./holidays.md)
*   [Examples](./holidays.md)