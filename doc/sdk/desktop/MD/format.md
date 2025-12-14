**Path**: [Performance Metrics](./performance_metrics.md) > [Format()](./format.md)

# Format()

# Format()

## [Definition](./format.md)

This method allows you to customize the rendering of the performance value on the Summary grid.

## [Syntax](./format.md)

`public override string Format(object value, Cbi.PerformanceUnit unit, string propertyName)`

## [Examples](./format.md)

```csharp
public override string Format(object value, Cbi.PerformanceUnit unit, string propertyName)
{
    double[] tmp = value as double[];
    if (tmp != null && tmp.Length == 5)
        switch (unit)
        {
          case Cbi.PerformanceUnit.Currency : return Core.Globals.FormatCurrency(tmp[0], denomination);
          case Cbi.PerformanceUnit.Percent   : return tmp[1].ToString("P");
          case Cbi.PerformanceUnit.Pips : return Math.Round(tmp[2]).ToString(Core.Globals.GeneralOptions.CurrentCulture);
          case Cbi.PerformanceUnit.Points : return Math.Round(tmp[3]).ToString(Core.Globals.GeneralOptions.CurrentCulture);
          case Cbi.PerformanceUnit.Ticks : return Math.Round(tmp[4]).ToString(Core.Globals.GeneralOptions.CurrentCulture);
        }
    return value.ToString();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./format.md)
*   [Syntax](./format.md)
*   [Examples](./format.md)