using System;

namespace PoundsToDollars
{
    class PoundsToDollars
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = 1.31M;
            decimal sum = pounds * dollars;

            Console.WriteLine($"{sum:N3}");
        }
    }
}
