**Path**: [OnConnectionStatusUpdate()](./onconnectionstatusupdate.md)

# OnConnectionStatusUpdate()

# OnConnectionStatusUpdate()

## [Definition](./onconnectionstatusupdate.md)

An event driven method used which is called for every change in connection status.

## [Method Return Value](./onconnectionstatusupdate.md)

This method does not return a value.

## [Syntax](./onconnectionstatusupdate.md)

You must override the method in your indicator with the following syntax:

**protected override void OnConnectionStatusUpdate(ConnectionStatusEventArgs connectionStatusUpdate)**

## [Method Parameters](./onconnectionstatusupdate.md)

**connectionStatusUpdate**

A **[ConnectionStatusEventArgs](./connectionstatuseventargs.md)** object representing the most recent update in connection.

**Status**

Represents the status of the key adapter functionality. If the adapter supports live orders it will set Status to Disconnected when its order system is not connected.

**PriceStatus**

Represents the status of the price feed.

## [Examples](./onconnectionstatusupdate.md)

```csharp
protected override void OnConnectionStatusUpdate(ConnectionStatusEventArgs connectionStatusUpdate)
{
   if(connectionStatusUpdate.Status == ConnectionStatus.Connected)
   {
     Print("Connected for orders at " + DateTime.Now);
   }

   else if(connectionStatusUpdate.Status == ConnectionStatus.ConnectionLost)
   {
     Print("Connection for orders lost at: " + DateTime.Now);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp

protected override void OnConnectionStatusUpdate(ConnectionStatusEventArgs connectionStatusUpdate)

{

   if(connectionStatusUpdate.PriceStatus == ConnectionStatus.Connected)

   {

     Print("Connected to price feed at " + DateTime.Now);

   }

   else if(connectionStatusUpdate.PriceStatus == ConnectionStatus.ConnectionLost)

   {

     Print("Connection to price feed lost at: " + DateTime.Now);

   }

}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onconnectionstatusupdate.md)
*   [Method Return Value](./onconnectionstatusupdate.md)
*   [Syntax](./onconnectionstatusupdate.md)
*   [Method Parameters](./onconnectionstatusupdate.md)
*   [Examples](./onconnectionstatusupdate.md)