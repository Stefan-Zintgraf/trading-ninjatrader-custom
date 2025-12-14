**Path**: [Strategy](./strategy_overview.md) > [Plotting from within a NinjaScript Strategy](./plotting_from_within_a_ninjascript_strategy.md)

# Plotting from within a NinjaScript Strategy

# Plotting from within a NinjaScript Strategy

When running a strategy on a chart you may find the need to plot values onto a chart. If these values are internal strategy calculations that are difficult to migrate to an indicator, you can use the following technique to achieve a plot.

With **NinjaTrader 8** we introduced strategy plots which provide the ability for a strategy to render its own plots. These plots must be specific to a single panel just like indicators. If you need to have strategy plots on more than a single panel then please use the technique seen in the attached sample. You can find documentation on the standard methods for plotting in the **Indicator** help guide section, although the documents are for indicators the plotting items are shared between indicators and strategies.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Important related documentation:

*   [Plotting from a strategy with Indicator plot methods](./addplot.md)

## [Import instructions](./plotting_from_within_a_ninjascript_strategy.md)

1.  Download the file contained in this Help Guide topic to your PC desktop.
2.  From the Control Center window, select the menu **Tools** > **Import** > **NinjaScript**.
3.  Select the downloaded file.

[SampleStrategyPlot\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleStrategyPlot_NT8.zip)

#### ON THIS PAGE

*   [Import instructions](./plotting_from_within_a_ninjascript_strategy.md)