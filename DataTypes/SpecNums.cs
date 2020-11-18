using System;

namespace SpacialNumbers
{
    class SpecNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sumOfDigits = 0;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num /= 10;
                }
                bool specialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {specialNum}");
            }
        }
    }
}
