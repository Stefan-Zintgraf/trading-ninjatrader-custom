**Path**: [Trading Hours](./tradinghours.md) > [Get()](./tradinghoursget.md)

# Get()

# Get()

## [Description](./tradinghoursget.md)

Returns the [TradingHours](./tradinghours.md) object for the specified Trading Hours template name, such as "CME US Index Futures RTH"

## [Method Return Value](./tradinghoursget.md)

A [TradingHours](./tradinghours.md) object representing the specified Trading Hours template name.

## [Syntax](./tradinghoursget.md)

`Get(string name)`

## [Parameters](./tradinghoursget.md)

name

The name of the desired TradingHours object to return

## [Examples](./tradinghoursget.md)

```csharp
// Loop through and print all regular holidays in the found TradingHours object
foreach(KeyValuePair<DateTime, string> holiday in TradingHours.Get("CME US Index Futures RTH").Holidays)
{
  Print(String.Format("Date: {0} Description: {1}", holiday.Key, holiday.Value));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./tradinghoursget.md)
*   [Method Return Value](./tradinghoursget.md)
*   [Syntax](./tradinghoursget.md)
*   [Parameters](./tradinghoursget.md)
*   [Examples](./tradinghoursget.md)