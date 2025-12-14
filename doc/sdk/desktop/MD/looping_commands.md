**Path**: [Tips](./tips.md) > [Looping Commands](./looping_commands.md)

# Looping Commands

# Looping Commands

Looping commands control execution flow of your script. If you wanted to print the word **NinjaTrader** 100 times, you could either use 100 lines of code or do the same using a looping command in only a few lines of code.

## [While Loop](./looping_commands.md)

```csharp
while (Boolean expression)
{
     //Do something here
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// Print NinjaTrader 100 times to the output window
int x = 0;
while (x < 100)
{
      Print("NinjaTrader");
      x = x + 1;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Do While Loop](./looping_commands.md)

```csharp
do
{
     //Do something here
}
while (Boolean expression)

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// Print NinjaTrader 100 times to the output window
int x = 0;
do
{
      Print("NinjaTrader");
      x = x + 1;
}
while (x < 100)

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [For Loop](./looping_commands.md)

```csharp
for (initializer; boolean expression; iterator)
{
     //Do something here
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// Print NinjaTrader 100 times to the output window
for (int x = 0; x < 100; x++)
{
      Print("NinjaTrader");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// Print NinjaTrader 100 times to the output window
for (int x = 0; x < 100; x++)
{
      Print("NinjaTrader");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Foreach Loop](./looping_commands.md)

```csharp
foreach (type identifier in boolean expression)
{
     // Do something here
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// Count the number of oatmeal cookies in a cookie jar
int oatmealCookies = 0;
foreach (cookie in cookieJar)
{
*      if (cookie.Type == Oatmeal)
      {
          oatmealCookies = oatmealCookies + 1;
      }
}
Print("There are " + numberOatmeal.ToString() + " oatmeal cookies in the cookie jar.");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Break and Continue](./looping_commands.md)

You can use the **break** command to exit a loop at any time. The following example is an infinite loop, but we will break out after the first **Print** statement.

```csharp
// Exit the infinite loop after the first iteration
* while (0 == 0)
* {
      Print("NinjaTrader");
      break;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

The **continue** command will jump ahead to the next iteration of the loop. The following example will never print **NinjaTrader**, because the **continue** command sends control back to the top of the loop each time.

```csharp
// Never prints "NinjaTrader"

for (int x = 0; x < 100; x++)
{
      continue;
      Print("NinjaTrader");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// Never prints "NinjaTrader"
for (int x = 0; x < 100; x++)
{
      continue;
      Print("NinjaTrader");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [While Loop](./looping_commands.md)
*   [Do While Loop](./looping_commands.md)
*   [For Loop](./looping_commands.md)
*   [Foreach Loop](./looping_commands.md)
*   [Break and Continue](./looping_commands.md)