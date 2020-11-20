using System;

namespace TopNumber
{
    class TopNum
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTopNumbers(num);
        }

        static void PrintTopNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (IsSumDivisibleBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HasOddDigit(int number)
        {
            while (number != 0)
            {
                if ((number % 10)% 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool IsSumDivisibleBy8(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }
            if (digitSum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
