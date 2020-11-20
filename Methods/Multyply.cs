using System;
using System.Linq;

namespace MultuplyEvensByOdds
{
    class Multyply
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            int result = GetMultiply(num);
            Console.WriteLine(result);
        }

        static int GetMultiply(int num)
        {
            int result = GetEvenSum(num) * GetOddSum(num);
            return result;
        }
        static int GetEvenSum(int num)
        {
            int evenSum = 0;
            while (num != 0)
            {
                int nextNum = num % 10;
                if (nextNum % 2 == 0)
                {
                    evenSum += nextNum;
                }
                num /= 10;
            }

            return evenSum;
        }
        static int GetOddSum(int num)
        {
            int oddSum = 0;
            while (num != 0)
            {
                int nextNum = num % 10;
                if (nextNum % 2 == 1)
                {
                    oddSum += nextNum;
                } 
                num /= 10;
            }

            return oddSum;
        }
    }
}
