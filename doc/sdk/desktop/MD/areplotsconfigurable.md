**Path**: [AddPlot()](./addplot.md) > [ArePlotsConfigurable](./areplotsconfigurable.md)

# ArePlotsConfigurable

# ArePlotsConfigurable

## [Definition](./areplotsconfigurable.md)

Determines if the plot(s) used in an indicator are configurable within the indicator dialog window.

## [Property Value](./areplotsconfigurable.md)

A **bool** which returns true if any indicator plot(s) are configurable; otherwise, false. Default set to true.

## [Syntax](./areplotsconfigurable.md)

`ArePlotsConfigurable`

## [Examples](./areplotsconfigurable.md)

```csharp
  protected override void OnStateChange()
  {
      if (State == State.SetDefaults)
      {
          AddPlot(Brushes.Orange, "SMA");
          ArePlotsConfigurable = false; // Plots are not configurable in the indicator dialog
      }
  }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./areplotsconfigurable.md)
*   [Property Value](./areplotsconfigurable.md)
*   [Syntax](./areplotsconfigurable.md)
*   [Examples](./areplotsconfigurable.md)