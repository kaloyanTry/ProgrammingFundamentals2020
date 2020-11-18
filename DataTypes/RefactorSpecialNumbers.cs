using System;

namespace RefactorSpecialNums
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isSpecial = true;
            for (int i = 1; i <= num; i++)
            {
                int number = i;
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }
    }
}
