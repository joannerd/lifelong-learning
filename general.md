# General Concepts

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
