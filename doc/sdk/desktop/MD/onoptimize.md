**Path**: [Optimizer](./optimizer.md) > [OnOptimize()](./onoptimize.md)

# OnOptimize()

# OnOptimize()

## [Definition](./onoptimize.md)

This method must be overridden in order to optimize a strategy. This method is called once per optimization run (not once per iteration).

## [Method Return Value](./onoptimize.md)

This method does not return a value.

## [Syntax](./onoptimize.md)

You must override the method in your Optimizer with the following syntax.

`protected override void OnOptimize() { }`

## [Examples](./onoptimize.md)

```csharp

protected override void OnOptimize()
{
     // If there is no optimization objective, return
     if (Strategies[0].OptimizationParameters.Count == 0)
         return;

     // Optimizer logic
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onoptimize.md)
*   [Method Return Value](./onoptimize.md)
*   [Syntax](./onoptimize.md)
*   [Examples](./onoptimize.md)