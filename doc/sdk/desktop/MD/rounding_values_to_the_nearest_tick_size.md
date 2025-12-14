**Path**: [Strategy](./strategy_overview.md) > [Rounding values to the nearest tick size](./rounding_values_to_the_nearest_tick_size.md)

# Rounding values to the nearest tick size

# Rounding values to the nearest tick size

When NinjaTrader receives a request to submit an order, it automatically rounds any limit price or stop price to the nearest tick for that specific instrument.

When debugging and/or printing out order information, this may not be apparent. NinjaTrader includes a Method named **RoundToTickSize** to apply the same internal rounding to any value you wish, which can help make comparisons easier.

## [Key concepts in this example](./rounding_values_to_the_nearest_tick_size.md)

*   Rounding a value to the nearest tick

## [Important related documentation](./rounding_values_to_the_nearest_tick_size.md)

*   [RoundToTickSize()](./roundtoticksize.md)
*   [EnterLongLimit()](./enterlonglimit.md)
*   [ExitLong()](./exitlong.md)
*   [CrossAbove()](./crossabove.md)
*   [CrossBelow()](./crossbelow.md)

## [Import instructions](./rounding_values_to_the_nearest_tick_size.md)

1.  Download the file contained in this Help Guide topic to your PC desktop
2.  From the Control Center window, select the menu Tools > Import > NinjaScript
3.  Select the downloaded file

[SampleRoundToTickSize\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleRoundToTickSize_NT8.zip)

#### ON THIS PAGE

*   [Key concepts in this example](./rounding_values_to_the_nearest_tick_size.md)
*   [Important related documentation](./rounding_values_to_the_nearest_tick_size.md)
*   [Import instructions](./rounding_values_to_the_nearest_tick_size.md)