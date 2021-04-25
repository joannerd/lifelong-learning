using System;
public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    
    // C#6: Default attribute properties
    public string MiddleName { get; } = "";

    public Person(string first, string middle, string last)
    {
        FirstName = first;
        MiddleName = middle;
        LastName = last;
    }

    // C#6: Lightweight syntax (vs old syntax below)
    public override string ToString() => FirstName + " " + LastName;

    // public override string ToString()
    // {
    //     return FirstName + " " + LastName;
    // }

    public string AllCaps() => ToString().ToUpper();

    // public string AllCaps()
    // {
    //     return ToString().ToUpper();
    // }
}
