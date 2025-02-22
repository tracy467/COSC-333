using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            int f1 = 0, f2 = 1, f3 = 0;

            if (count == 1)
            {
                Console.WriteLine(f1);
            }
            else if (count == 2)
            {
                Console.WriteLine(f1);
                Console.WriteLine(f2);
            }
            else
            {
                for (int i = 3; i <= count; i++)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                }
                Console.WriteLine(f3);
            }

            Console.ReadLine();
        }
    }
}
