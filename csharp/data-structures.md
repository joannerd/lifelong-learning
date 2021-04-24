# Data Structures

## [List]
  - performs better than [ArrayList]
  - `.Count` property
  - `.HasValue` property
  - `.IndexOf()`
  - `.Sort()`
  - `.Add()`
  - `.Remove()`
  - `.Contains()`
  - `.Exists()`
  - `.LastIndexOf()`
  - `.BinarySearch()`

## [StringBuilder]

  - `.Length` property
  - `.Append(new char[] { 'D', 'E', 'F' })`
  - `.AppendFormat("GHI{0}{1}", 'J', 'k')`
  - `.ToString()`
  - `.Insert(0, "Alphabet: ")`
  - `.Replace('k', 'K')`

## [New Object Initialization Syntax]

```c#
private static void Main()
{
    var messages = new Dictionary<int, string>
    {
        [404] = "Page not Found",
        [302] = "Page moved, but left a forwarding address.",
        [500] = "The web server can't come out to play today."
    };

    Console.WriteLine(messages[302]);
}
```

## [Span]

- Often used to hold the elements of an array or a portion of an array
- Type/memory-safe representation of a contiguous region of arbitrary memory
- [ref] struct
- can't be:
  - boxed
  - assigned to variables of type `Object`
  - `dynamic`
  - used across `await` and `yield`

[List]:
    https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1

[ArrayList]:
    https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=netcore-3.1
    
[StringBuilder]:
  https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=netcore-3.1

[New Object Initialization Syntax]:
  https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/exploration/csharp-6?tutorial-step=9

[Span]:
  https://docs.microsoft.com/en-us/dotnet/api/system.span-1?view=netcore-3.1

[ref]: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#ref-struct