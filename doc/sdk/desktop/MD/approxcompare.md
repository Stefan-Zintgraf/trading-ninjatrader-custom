**Path**: [Analytical](./analytical.md) > [ApproxCompare()](./approxcompare.md)

# ApproxCompare()

# ApproxCompare()

## [Definition](./approxcompare.md)

Compares two double or float values for equality or being greater than / less than the compared to value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Comparing for being greater than / less is done using an epsilon value of 1E19

## [Method Return Value](./approxcompare.md)

An **int** value representing the outcome of the comparison. Returns 0 if values are equal, 1 if value1 is greater than value2. \-1 if value1 is less than value2.

## [Syntax](./approxcompare.md)

`this.ApproxCompare(this double double1, double double2)`

`this.ApproxCompare(this float float1, double float2)`

## [Parameters](./approxcompare.md)

Parameter

Description

double1 / float1

First value to compare against (not actually passed in)

double2 / float2

Second passed in value to compare against

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Main use would be using it for equality comparisons to circumvent running into floating point considerations, value compares for < or > could be usually done more straightforward directly.

## [Examples](./approxcompare.md)

```csharp
// Build the High / Low difference and if 0 sets the indicator main Value series to 0
if ((High[0] - Low[0]).ApproxCompare(0) == 0)
   Value[0] = 0;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./approxcompare.md)
*   [Method Return Value](./approxcompare.md)
*   [Syntax](./approxcompare.md)
*   [Parameters](./approxcompare.md)
*   [Examples](./approxcompare.md)