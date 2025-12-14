**Path**: [Optimizer](./optimizer.md) > [OptimizationParameters](./optimizationparameters.md)

# OptimizationParameters

# OptimizationParameters

## [Definition](./optimizationparameters.md)

The optimization parameters selected for the optimization run. (e.g. user parameters or Data Series)

## [Property Value](./optimizationparameters.md)

A bool value.

## [Syntax](./optimizationparameters.md)

`Strategies[0].OptimizationParameters`

## [Examples](./optimizationparameters.md)

```csharp
protected override void OnOptimize()
{
     // If there are no optimization parameters to optimize, return
     if (Strategies[0].OptimizationParameters.Count == 0)
         return;

     // Do something with the optimization parameter
     Parameter parameter = Strategies[0].OptimizationParameters[0];
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./optimizationparameters.md)
*   [Property Value](./optimizationparameters.md)
*   [Syntax](./optimizationparameters.md)
*   [Examples](./optimizationparameters.md)