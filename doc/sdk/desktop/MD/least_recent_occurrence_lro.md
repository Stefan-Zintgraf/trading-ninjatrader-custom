**Path**: [Analytical](./analytical.md) > [Least Recent Occurrence (LRO)](./least_recent_occurrence_lro.md)

# Least Recent Occurrence (LRO)

# Least Recent Occurrence (LRO)

## [Definition](./least_recent_occurrence_lro.md)

Returns the number of bars ago that the test condition evaluated to true within the specified look back period expressed in bars. The **LRO()** method starts from the furthest bar away and works toward the current bar.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method does NOT work on [multi\-series](./multi_time_frame_instruments.md) strategies and indicators.

## [Method Return Value](./least_recent_occurrence_lro.md)

An **int** value representing the number of bars ago. Returns a value of \-1 if the specified test condition did not evaluate to true within the look\-back period.

## [Syntax](./least_recent_occurrence_lro.md)

`LRO(Func<bool> condition, int instance, int lookBackPeriod)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

1.  The "instance" parameter MUST be greater than 0.
2.  The "lookBackPeriod" parameter MUST be greater than 0.
3.  Please check the Log tab for any other exceptions that may be thrown by the condition function parameter.

## [Parameters](./least_recent_occurrence_lro.md)

Parameter

Description

**condition**

A true/false expression

**instance**

The occurrence to check for (1 is the least recent, 2 is the 2nd least recent, etc...)

**lookBackPeriod**

The number of bars to look back to check for the test condition. The test evaluates on the current bar and the bars within the look\-back period.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The syntax for the "condition" parameter uses [lambda expression](http://msdn.microsoft.com/en-us/library/bb397687.aspx) syntax.

## [Examples](./least_recent_occurrence_lro.md)

```csharp
protected override void OnBarUpdate()
{
    // Prints the high price of the least recent up bar over the last 10 bars (current bar + look back period's 9 bars before that)
    int barsAgo = LRO(() => Close[0] > Open[0], 1, 9);
    if (barsAgo > -1)
        Print("The bar high was " + High[barsAgo]);         
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [See Also](./least_recent_occurrence_lro.md)

[Most Recent Occurrence(MRO)](./most_recent_occurrence_mro.md)

#### ON THIS PAGE

*   [Definition](./least_recent_occurrence_lro.md)
*   [Method Return Value](./least_recent_occurrence_lro.md)
*   [Syntax](./least_recent_occurrence_lro.md)
*   [Parameters](./least_recent_occurrence_lro.md)
*   [Examples](./least_recent_occurrence_lro.md)
*   [See Also](./least_recent_occurrence_lro.md)