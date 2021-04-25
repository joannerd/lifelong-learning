# .NET Core Notes

## Setup

1. Create project
  - `dotnet new console -o myApp`
    - `new` = create new app
    - `console` = app is type _console_
    - `-o myApp` = create `myApp` project directory and populate with files
  - **or** `dotnet new console -n NumbersInCSharp -o .`
    - `-n NumbersInCSharp` = create `NumbersInCSharp` namespace
    - `-o .` populate current directory with files
2. Run project: `dotnet run`
  - main file is `Program.cs`