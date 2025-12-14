**Path**: [Connection](./connection_class.md) > [Options](./connections_options.md)

# Options

# Options

## [Definition](./connections_options.md)

The connection's configuration options

## [Properties](./connections_options.md)

ConnectOnStartup

A bool representing if this connection auto connects on startup \-\-

Name

A string representing the connection's name

Provider

A Provider representing the connection's provider

## [Examples](./connections_options.md)

```csharp
// Example of accessing information on all connected connections
public class MyAddOnTab : NTTabPage
{
    public MyAddOnTab()
    {
        // Print information about all connected connections
        lock (Connection.Connections)
            Connection.Connections.ToList().ForEach(c => NinjaTrader.Code.Output.Process(string.Format("Connection: {0} Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1));
    }

    // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./connections_options.md)
*   [Properties](./connections_options.md)
*   [Examples](./connections_options.md)