using System;
using System.Diagnostics;
using System.Numerics;

namespace ExactSum
{
    class SumRealNums
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
