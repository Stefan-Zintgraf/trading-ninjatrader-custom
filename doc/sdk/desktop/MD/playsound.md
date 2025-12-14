**Path**: [Alert, Debug, Share](./alert_debug_share.md) > [PlaySound()](./playsound.md)

# PlaySound()

# PlaySound()

## [Definition](./playsound.md)

Plays a .wav file while running on real\-time data.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  This method will only execute once the **State** has reached **State.Realtime**. Calls to this method during **State.Historical** will be ignored (in contrast to the implementation for **AddOns**).
2.  The default behavior is to play the .wav file in an asynchronous manner, which can result in calls to **PlaySound()** to play over one another. Sound files can optionally be configured to execute in a synchronous manner by enabling the Tools > Options > Sounds > "Play consecutively" property.

## [Method Return Value](./playsound.md)

This method does not return a value.

## [Syntax](./playsound.md)

`PlaySound(string fileName)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

The underlying framework used to play the sound requires the audio file to be in PCM .wav format. Using another file format will generate an error at runtime.

## [Parameters](./playsound.md)

Parameter

Description

**fileName**

The absolute file path of the .wav file to play

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

You can obtain the default NinjaTrader installation directory to access the sounds folder by using **NinjaTrader.Core.Globals.InstallDir** property. Please see the example below for usage.

## [Examples](./playsound.md)

```csharp
// Plays the wav file mySound.wav
PlaySound(@"C:\mySound.wav");

// Plays the default Alert1 sound that comes packaged with NinjaTrader
PlaySound(NinjaTrader.Core.Globals.InstallDir + @"\sounds\Alert1.wav");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./playsound.md)
*   [Method Return Value](./playsound.md)
*   [Syntax](./playsound.md)
*   [Parameters](./playsound.md)
*   [Examples](./playsound.md)