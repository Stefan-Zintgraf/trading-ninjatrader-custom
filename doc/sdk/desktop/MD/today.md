**Path**: [Analytical](./analytical.md) > [ToDay()](./today.md)

# ToDay()

# ToDay()

## [Definition](./today.md)

Calculates an integer value representing a date.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Integer representation of day is format as yyyyMMdd where January 8, 2015 would be 20150108.

## [Method Return Value](./today.md)

An **int** value representing date structure.

## [Syntax](./today.md)

`ToDay(DateTime time)`

## [Parameters](./today.md)

Parameter

Description

**time**

A DateTime structure to calculate. Note: See also the [Time](./time.md) property.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tip: NinjaScript uses the .NET [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structures which can be complicated for novice programmers. If you are familiar with **C#** you can directly use DateTime structure properties and methods for date and time comparisons otherwise use this method and the [ToTime()](./totime.md) method.

## [Examples](./today.md)

```csharp
protected override void OnBarUpdate()
{   
    // Compare the date of the current bar to September 15, 2014
    if (ToDay(Time[0]) > 20140915)
    {
        // Do something       
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./today.md)
*   [Method Return Value](./today.md)
*   [Syntax](./today.md)
*   [Parameters](./today.md)
*   [Examples](./today.md)