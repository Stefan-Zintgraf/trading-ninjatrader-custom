**Path**: [Analytical](./analytical.md) > [CountIf()](./countif.md)

# CountIf()

# CountIf()

## [Definition](./countif.md)

Counts the number of instances the test condition occurs over the look\-back period expressed in bars.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method does NOT work on **multi\-series** strategies and indicators.

## [Method Return Value](./countif.md)

An **int** value representing the number of occurrences found.

## [Syntax](./countif.md)

`CountIf(Func<bool> condition, int period)`

## [Parameters](./countif.md)

**condition**

A true/false expression

**period**

Number of bars to check for the test condition

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tip: The syntax for the "condition" parameter uses [lambda expression](http://msdn.microsoft.com/en-us/library/bb397687.aspx) syntax.

## [Examples](./countif.md)

```csharp
// If in the last 10 bars we have had 8 up bars then go long
if (CountIf(() => Close[0] > Open[0], 10) > 8)
     EnterLong();

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./countif.md)
*   [Method Return Value](./countif.md)
*   [Syntax](./countif.md)
*   [Parameters](./countif.md)
*   [Examples](./countif.md)