using System;
using System.Numerics;

namespace TribonacciSequence
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (n == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");
                GetTribunacciNum(n);
            }
        }

        static void GetTribunacciNum(BigInteger num)
        {
            BigInteger nMinus3 = 1;
            BigInteger nMinus2 = 1;
            BigInteger nMinus1 = 2;

            BigInteger maxLimit = num;
            for (int i = 0; i < maxLimit - 3; i++)
            {
                num = nMinus3 + nMinus2 + nMinus1;
                nMinus3 = nMinus2;
                nMinus2 = nMinus1;
                nMinus1 = num;
                Console.Write($"{num} ");
            }
        }
    }
}
