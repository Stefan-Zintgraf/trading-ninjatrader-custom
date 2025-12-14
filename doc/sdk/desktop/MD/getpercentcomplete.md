**Path**: [Bars Type](./bars_type.md) > [GetPercentComplete()](./getpercentcomplete.md)

# GetPercentComplete()

# GetPercentComplete()

## [Definition](./getpercentcomplete.md)

Determines the value your **BarsType** would return for [**Bars.PercentComplete**](./percentcomplete.md).

## [Method Return Value](./getpercentcomplete.md)

This method returns A **double** value.

## [Method Parameters](./getpercentcomplete.md)

**bars**

The [**bars**](./bars.md) object chosen by the user when utilizing this Bars type

**now**

The **DateTime** value to measure

## [Syntax](./getpercentcomplete.md)

You must override the method in your Bars Type with the following syntax.

`public override double GetPercentComplete(Bars bars, DateTime now) { }`

## [Examples](./getpercentcomplete.md)

```csharp
public override double GetPercentComplete(Bars bars, DateTime now)
{
     // Calculate the percent complete for our monthly bars
     if (now.Date <= bars.LastBarTime.Date)
     {
         int month = now.Month;
         int daysInMonth = (month == 2) ? (DateTime.IsLeapYear(now.Year) ? 29 : 28) : 
               (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 ? 31 : 30);
         return (daysInMonth - (barsSeries.LastBarTime.Date.AddDays(1).Subtract(now).TotalDays / barsSeries.BarsPeriod.Value)) /
               daysInMonth; // an estimate
     }
     return 1;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getpercentcomplete.md)
*   [Method Return Value](./getpercentcomplete.md)
*   [Method Parameters](./getpercentcomplete.md)
*   [Syntax](./getpercentcomplete.md)
*   [Examples](./getpercentcomplete.md)