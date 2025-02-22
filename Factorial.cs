using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number to calculate its factorial: ");
            number = int.Parse(Console.ReadLine());

            long result = 1;

            // Calculate factorial using a loop
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine($"Factorial of {number} is: {result}");
            Console.ReadLine();
        }
    }
}
