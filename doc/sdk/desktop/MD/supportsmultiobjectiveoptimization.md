**Path**: [Optimizer](./optimizer.md) > [SupportsMultiObjectiveOptimization](./supportsmultiobjectiveoptimization.md)

# SupportsMultiObjectiveOptimization

# SupportsMultiObjectiveOptimization

## [Definition](./supportsmultiobjectiveoptimization.md)

Informs the Strategy Analyzer if this Optimizer can do multi\-objective optimizations.

## [Property Value](./supportsmultiobjectiveoptimization.md)

A bool value.

## [Syntax](./supportsmultiobjectiveoptimization.md)

`SupportsMultiObjectiveOptimization`

## [Examples](./supportsmultiobjectiveoptimization.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
          Name = "MyOptimizer";
          SupportsMultiObjectiveOptimization = true;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./supportsmultiobjectiveoptimization.md)
*   [Property Value](./supportsmultiobjectiveoptimization.md)
*   [Syntax](./supportsmultiobjectiveoptimization.md)
*   [Examples](./supportsmultiobjectiveoptimization.md)