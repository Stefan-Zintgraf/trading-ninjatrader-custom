**Path**: [Tips](./tips.md) > [Parameter sequencing](./parameter_sequencing.md)

# Parameter sequencing

# Parameter sequencing

## [Parameter sequencing](./parameter_sequencing.md)

Indicator and strategy parameters (user defined inputs) will always be displayed in an order that the user specifies in the **NinjaScript** file.

In the **NinjaScript Editor**, expand the "Properties" region of your code where all of your parameters are defined. In this example, this will be our Properties section:

```csharp
[Range(1, int.MaxValue), NinjaScriptProperty]
[Display(ResourceType = typeof(Custom.Resource), Name = "Fast", GroupName = "NinjaScriptStrategyParameters", Order = 0)]
public int Fast
{ get; set; }

```csharp
[Range(1, int.MaxValue), NinjaScriptProperty]
[Display(ResourceType = typeof(Custom.Resource), Name = "Slow", GroupName = "NinjaScriptStrategyParameters", Order = 1)]
public int Slow
{ get; set;}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In this case, the **Fast** parameter will show up as the first parameter with the **Slow** parameter showing as the second.

To switch the order around, we could modify **Order**. If we change **Slow**'s **Order** to 0 and **Fast**'s **Order** to 1 as shown below ...

```csharp
[Range(1, int.MaxValue), NinjaScriptProperty]
[Display(ResourceType = typeof(Custom.Resource), Name = "Fast", GroupName = "NinjaScriptStrategyParameters", Order = 1)]
public int Fast
{ get; set; }

[Range(1, int.MaxValue), NinjaScriptProperty]
[Display(ResourceType = typeof(Custom.Resource), Name = "Slow", GroupName = "NinjaScriptStrategyParameters", Order = 0)]
public int Slow
{ get; set; }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

... the **Slow** property will show first and the **Fast** property second.

#### ON THIS PAGE

*   [Parameter sequencing](./parameter_sequencing.md)