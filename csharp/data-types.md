# Data Types

- [Built-in Types]
- [void]: indicate absence of a type or that a method doesn't return a value

## Types

- Strings:
  - `string` keyword = alias for `String`
  - Helpful methods:
    - `.TrimStart()`
    - `.TrimEnd()`
    - `.Trim()`
    - `.Replace("a", "b")`
    - `.ToUpper()`
    - `.ToLower()`
    - `.Contains()`
    - `.StartsWith()`
    - `.EndsWith()`
    - `new StringBuilder()` + `.Append()`
    - `WriteLine($"The average word length is: {wordLength.Average():F2}")` (`:` formats string)
  - immutable (strings behave like value types)
  ```c#
  public void StringsBehaveLikeValueTypes()
  {
      string name = "Korra";
      MakeReferenceUppercase(name);
      var upper = MakeUppercase(name);

      Assert.Equal("Korra", name);
      Assert.Equal("KORRA", upper);
  }

  private void MakeReferenceUppercase(string parameter)
  {
      parameter.ToUpper();
  }

  private string MakeUppercase(string parameter)
  {
      return parameter.ToUpper();
  }
  ```
- Numbers:
  - int `1`
  - double `1.0`
  - decimal `1.0M`
  - [Math.PI] `public const double PI = 3.1415926535897931;`
  - `int.TryParse(<inpu>, out <outputVariable>)` (returns `false` when unable to parse)
  - `int.Parse("1.0")`
  - `double.Parse("1.0")`
- Bool:
  - `bool.Parse("False")`

[Built-in Types]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types

[Math.PI]:
  https://docs.microsoft.com/en-us/dotnet/api/system.math.pi?view=netcore-3.1

[void]:
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/void
