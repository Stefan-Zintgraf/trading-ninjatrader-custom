**Path**: [Alert, Debug, Share](./alert_debug_share.md) > [Log()](./log.md)

# Log()

# Log()

## [Definition](./log.md)

Generates a NinjaScript category log event record and associated time stamp which is output to the **Log** tab of the NinjaTrader Control Center / Account Data windows. The **Log()** method also writes records to the NinjaTrader log file which can be useful for supporting 3rd party code.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  Log events do NOT process to the NinjaScript output window. For temporary logging, please see the **Print()** method and **Output window**.
2.  The Log event time stamp represents the user configured Time zone from the Tools > Options > General category. This setting could be different from the computer system's time zone.

## [Method Return Value](./log.md)

This method does not return a value.

## [Syntax](./log.md)

`Log(string message, LogLevel logLevel)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Each call to this method creates a log entry which takes memory to keep loaded in the Log tab of the Control Center. Excessive logging can result in huge portions of memory being allocated to display the log messages. Please see the NinjaScript section of the **Performance Tips** article for more information.

## [Parameters](./log.md)

**message**

A **string** value representing the message to be logged

**logLevel**

Sets the message level for the log event. Different levels are color coded in the NinjaTrader log.

*   **LogLevel.Alert** (also generates a pop\-up notification window with log message)
*   **LogLevel.Error**
*   **LogLevel.Information**
*   **LogLevel.Warning**

## [Examples](./log.md)

```csharp
// Generates a log message
Log("This is a log message", LogLevel.Information);

// Generates a log message with a notification window
Log("This will generate a pop-up notification window as well", LogLevel.Alert);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./log.md)
*   [Method Return Value](./log.md)
*   [Syntax](./log.md)
*   [Parameters](./log.md)
*   [Examples](./log.md)