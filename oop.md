# Classes in C#

- [static]: shared by all objects of the same class (belongs to type itself
  rather than specific instance), not modified by other instances

- [accessibility levels]:
    - [public]: no access restrictions
    - [protected]: accessible within its class or types derived from class with
      _protected_ members
    - [private]: only accessible by code within the class definition

1. Class declaration
    ```c#
    public class BankAccount
    {
    }
    ```

2. Getters/setters for public attributes
    ```c#
    public string Number { get; }
    public string Owner { get; set; }
    ```

3. Private attributes
    ```c#
    private static int accountNumberSeed = 1234567890;
    ```
4. Constructor
    ```c#
    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Balance = initialBalance;
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;
    }
    ```

5. Instance methods
    ```c#
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }
    ```

[static]:
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static

[accessibility levels]:
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/accessibility-levels

[public]:
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public

[private]:
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private

[protected]:
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected
