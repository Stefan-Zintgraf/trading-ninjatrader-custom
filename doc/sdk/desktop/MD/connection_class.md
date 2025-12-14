**Path**: [Connection](./connection_class.md)

# Connection

# Connection

## [Definition](./connection_class.md)

The Connection class can be used to monitor connection related events as well as accessing connection related information.

## [Static Connection Class Events and Properties](./connection_class.md)

Method

Description

[CancelAllOrders()](./cancelallorders.md)

Cancels all orders

[Connect()](./connect.md)

Connects to a connection

[ConnectionStatusUpdate](./connectionstatusupdate.md)

Event handler for connection status updates

## [Events and Properties from Connection instances](./connection_class.md)

Property

Description

[Accounts](./account_class.md)

List of accounts from the connection

[Disconnect()](./disconnect.md)

Disconnects from the connection

[Options](./connectoptions.md)

The connection's configuration options

[PriceStatus](./pricestatus.md)

A ConnectionStatus representing the status of the price feed. Possible values are:

*   ConnectionStatus.Connected
    
*   ConnectionStatus.Connecting
    
*   ConnectionStatus.ConnectionLost
    
*   ConnectionStatus.Disconnecting
    
*   ConnectionStatus.Disconnected
    

[Status](./status.md)

A ConnectionStatus representing the status of the order feed. Possible values are:

*   ConnectionStatus.Connected
    
*   ConnectionStatus.Connecting
    
*   ConnectionStatus.ConnectionLost
    
*   ConnectionStatus.Disconnecting
    
*   ConnectionStatus.Disconnected
    

## [Examples](./connection_class.md)

```csharp
// Example of accessing information on all connected connections  
public class MyAddOnTab : NTTabPage  
{  
  public MyAddOnTab()  
  {  
    // Print information about all connected connections  
    lock (Connection.Connections)  
      foreach(Connection c in Connection.Connections)  
          NinjaTrader.Code.Output.Process(string.Format("Connection: {0} Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1);  
   
    // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.  
  }  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./connection_class.md)
*   [Static Connection Class Events and Properties](./connection_class.md)
*   [Events and Properties from Connection instances](./connection_class.md)
*   [Examples](./connection_class.md)