using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 3;
            int b = 3;
            if (a + b > 10) {
                Console.WriteLine("The answer is greater than 10.");
            }
            else {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 10;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }
        static void ExporeWhile()
        {
            int iCounter = 0;
            while (iCounter < 10)
            {
                Console.WriteLine($"Hello World! The iCounter is {iCounter}");
                iCounter++;
            }

            int jCounter = 0;
            do
            {
                Console.WriteLine($"Hello World! The jCounter is {jCounter}");
                jCounter++;
            } while (jCounter < 10);
        }

        // sum of all integers 1 through 20 that are divisible by 3.
        static void DivisibleSum()
        {
            int number = 1;
            int sum = 0;
            while (number <= 20)
            {
                if (number % 3 == 0)
                {
                    sum += number;
                }
                number++;
            }
            Console.WriteLine(sum);
    }
        static void Main(string[] args)
        {
            // ExploreIf();
            // ExploreWhile();
            DivisibleSum();
        }
    }
}
