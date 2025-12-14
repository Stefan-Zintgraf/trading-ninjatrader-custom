**Path**: [Rendering](./rendering.md) > [DirectWriteFactory](./directwritefactory.md)

# DirectWriteFactory

# DirectWriteFactory

## [Definition](./directwritefactory.md)

Provides a default **DirectWrite** factory used for creating [**SharpDX.DirectWrite**](./sharpdx_directwrite.md) components.

## [Property Value](./directwritefactory.md)

A read\-only **SharpDX.DirectWrite.Factory** used to create DirectWrite objects compatible with **NinjaTrader** rendering.

## [Syntax](./directwritefactory.md)

`NinjaTrader.Core.Globals.DirectWriteFactory`

## [Examples](./directwritefactory.md)

```csharp
// create a text format object with default NinjaTrader DirectWrite factory

SharpDX.DirectWrite.TextFormat textFormat = new SharpDX.DirectWrite.TextFormat(NinjaTrader.Core.Globals.DirectWriteFactory,
   "Arial", 12f);

// create a text layout object with default NinjaTrader DirectWrite factory

SharpDX.DirectWrite.TextLayout textLayout = new SharpDX.DirectWrite.TextLayout(NinjaTrader.Core.Globals.DirectWriteFactory,

   "text to render", textFormat, ChartPanel.W, ChartPanel.H);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./directwritefactory.md)
*   [Property Value](./directwritefactory.md)
*   [Syntax](./directwritefactory.md)
*   [Examples](./directwritefactory.md)