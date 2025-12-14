**Path**: [Chart Style](./chart_style.md) > [BarWidth](./barwidth.md)

# BarWidth

# BarWidth

## [Definition](./barwidth.md)

The painted width of a ChartStyle bar. This value will updated as the ChartControl is resized.

## [Property Value](./barwidth.md)

A **double** value representing the current width the chart bars

## [Syntax](./barwidth.md)

`BarWidth`

## [Examples](./barwidth.md)

```csharp

protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Name             = "Example ChartStyle";
     ChartStyleType   = (ChartStyleType) 52;
     BarWidth         = 1;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barwidth.md)
*   [Property Value](./barwidth.md)
*   [Syntax](./barwidth.md)
*   [Examples](./barwidth.md)