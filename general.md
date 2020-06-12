# General Concepts

## Organization

## [Boxing / Unboxing]

**Boxing**: convert a _value type_ to type `object` (implicit)
```c#
int i = 123;
// The following line boxes i.
object o = i;
```

**Unboxing**: extract value type from the object (explicit)
```c#
o = 123;
i = (int)o;  // unboxing
```

## Loops

**[for]**

```c#
for (int i = 0; i < 10; i++)
{
    // loop stuff
}
```

**[foreach]**

```c#
Span<int> numbers = new int[] { 3, 14, 15, 92, 6 };
foreach (int number in numbers)
{
    // loop stuff
}
```

**[while]**

```c#
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
```

**[do-while]**

```c#
int counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);
```

**[throw]**

```c#
throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
```

- [standard exceptions]

**[try/catch]**

```c#
try
{
    var invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
}
```

**[try/catch-when]**

```c#
using System;

public class Program
{
    public static void Main()
    {
        try 
        {
            string s = null;
            Console.WriteLine(s.Length);

        } catch (Exception e) when (LogException(e))
        {
        }
        Console.WriteLine("Exception must have been handled");
    }

    private static bool LogException(Exception e)
    {
        Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
        Console.WriteLine($"\tMessage: {e.Message}");
        return false;
    }
}
```

**?. ([null conditional operator])**

```c#
string s = null;
Console.WriteLine(s.Length); // NullReferenceException thrown
Console.WriteLine(s?.Length); // no output

char? c = s?[0];
Console.WriteLine(c.HasValue);
```

**?. ([null coalescing operator])**

```c#
string s = null;
// bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext();
// Console.WriteLine(hasMore.HasValue && hasMore.Value);

bool hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
Console.WriteLine(hasMore);
```

**[String Formatting]**

- [Interpolation]
- [Numeric]
- [Date/time]
- [Alignment]

```c#
// `{..., -25}` = left alignment
Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");

// `:N2` = thousands separator + 0.00
Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
```

**[Indexes/Ranges]**

- `[..]` = `[0..^0]` = `[0..sequence.Length]`
- [Index] type: `Index word = ^3;`
- [Range] type: `Range phrase = 1..4;`

```c#
string[] words = new string[]
{
                // index from start    index from end
    "The",      // 0                   ^9
    "quick",    // 1                   ^8
    "brown",    // 2                   ^7
    "fox",      // 3                   ^6
    "jumped",   // 4                   ^5
    "over",     // 5                   ^4
    "the",      // 6                   ^3
    "lazy",     // 7                   ^2
    "dog"       // 8                   ^1
};              // 9 (or words.Length) ^0
```

[Boxing / Unboxing]:
  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing

[for]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for

[foreach]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in

[while]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while
  
[do-while]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do

[throw]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw

[standard exceptions]:
  https://docs.microsoft.com/en-us/dotnet/api/system.exception?view=netcore-3.1#choosing-standard-exceptions

[try/catch]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch

[try/catch-when]:
  https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/exploration/csharp-6?tutorial-step=7

[null conditional operator]:
  https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/null-conditional-operators

[null coalescing operator]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator

[String Formatting]:
  https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types#format-strings-and-net-types

[Interpolation]:
  https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation#code-try-0

[Numeric]:
  https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#the-currency-c-format-specifier

[Date/time]:
  https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings

[Alignment]:
  https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation#code-try-0

[Indexes/Ranges]:
  https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes

[Index]:
  https://docs.microsoft.com/en-us/dotnet/api/system.index

[Range]:
  https://docs.microsoft.com/en-us/dotnet/api/system.range

