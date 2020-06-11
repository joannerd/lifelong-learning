// `using static` vs `using`
// using static System.Console;
using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void WorkWithStrings()
    {
        var p = new Person("Bill", "Jo", "Wagner");
        Console.WriteLine("The name, in all caps: " + p.AllCaps());
        Console.WriteLine("The name: " + p);

        var phrase = "the quick brown fox jumps over the lazy dog";
        var wordLength = from word in phrase.Split(' ') select word.Length;
        // var average = wordLength.Average();
        // Console.WriteLine(average);
        Console.WriteLine($"The average word length is: {wordLength.Average():F2}");
    }

    public static void WorkWithNullOperators()
    {
        string s = null;
        Console.WriteLine(s?.Length);

        char? c = s?[0];
        Console.WriteLine(c.HasValue);
    }

    public static void WorkWithCatchWhen()
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
        // Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
        // Console.WriteLine($"\tMessage: {e.Message}");
        return true;
    }

    private static void WorkWithNameof()
    {
        Console.WriteLine(nameof(System.String));
        int j = 5;
        Console.WriteLine(nameof(j));
        List<string> names = new List<string>();
        Console.WriteLine(nameof(names));
    }

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
}