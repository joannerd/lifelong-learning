# [Namespaces]

- Used to organize classes
- ex: `System` in `System.Console.WriteLine()`
- `global` ("root" namespace): `global::System` always refers to the .NET [System] namespace

**without `using` keyword**

```c#
System.Console.WriteLine("Hello World!");
```
**with `using` keyword**

```c#
using System;
Console.WriteLine("Hello World!");
```

[Namespaces]:
  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/

[System]:
  https://docs.microsoft.com/en-us/dotnet/api/system?view=dotnet-plat-ext-3.1
  