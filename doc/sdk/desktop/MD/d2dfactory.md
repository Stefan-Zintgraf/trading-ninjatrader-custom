**Path**: [Rendering](./rendering.md) > [D2DFactory](./d2dfactory.md)

# D2DFactory

# D2DFactory

## [Definition](./d2dfactory.md)

Provides a default Direct2D1 factory used for creating **SharpDX.Direct2D1** components.

## [Property Value](./d2dfactory.md)

A read\-only **SharpDX.Direct2D1.Factory** to create Direct2D1 objects compatible with NinjaTrader rendering.

## [Syntax](./d2dfactory.md)

`NinjaTrader.Core.Globals.D2DFactory`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: Please ensure this property would only be accessed from `OnRender()` or `OnRenderTargetChanged()` (which run in the UI thread), as access from other threads outside those methods could cause a degradation in performance.

```csharp
// create a Direct2D1 PathGeometry format object with default NinjaTrader D2DFactory factory
SharpDX.Direct2D1.PathGeometry pathGeometry = new SharpDX.Direct2D1.PathGeometry(NinjaTrader.Core.Globals.D2DFactory);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./d2dfactory.md)
*   [Property Value](./d2dfactory.md)
*   [Syntax](./d2dfactory.md)