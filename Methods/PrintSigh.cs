using System;

namespace ConsoleApp1
{
    class PrintSigh
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSignNumber(n);
        }

        static void PrintSignNumber(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
        }
    }
}
