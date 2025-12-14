**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Psychological Line](./psychological_line.md)

# Psychological Line

# Psychological Line

## [Description](./psychological_line.md)

The Psychological Line is the ratio of the number of rising bars over the specified number of bars.

## [Syntax](./psychological_line.md)

`PsychologicalLine(int period)`

`PsychologicalLine(ISeries<double> input, int period)`

## [Return Value](./psychological_line.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./psychological_line.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./psychological_line.md)

```csharp
// Prints the current value of a 10 period Psychological Line
double value = PsychologicalLine(10)[0];
Print("The current Psychological Line value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./psychological_line.md)
*   [Syntax](./psychological_line.md)
*   [Return Value](./psychological_line.md)
*   [Parameters](./psychological_line.md)
*   [Examples](./psychological_line.md)