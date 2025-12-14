**Path**: [Optimizer](./optimizer.md) > [NumberOfIterations](./numberofiterations.md)

# NumberOfIterations

# NumberOfIterations

## [Definition](./numberofiterations.md)

Informs the Strategy Analyzer how many iterations of optimizing it needs to do.

## [Property Value](./numberofiterations.md)

An **int** value.

## [Syntax](./numberofiterations.md)

`NumberOfIterations`

## [Examples](./numberofiterations.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
         Name = "MyOptimizer";
     else if (State == State.Configure && Strategies.Count > 0)
         NumberOfIterations = 1;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./numberofiterations.md)
*   [Property Value](./numberofiterations.md)
*   [Syntax](./numberofiterations.md)
*   [Examples](./numberofiterations.md)