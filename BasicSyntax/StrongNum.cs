using System;

namespace StrongNumber
{
    class StrongNum
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int num = input;

            int currentNum = 0;
            int factorielSum = 0;

            while (num != 0)
            {
                currentNum = num % 10;
                num /= 10;

                int factoriel = 1;

                for (int i = 1; i <= currentNum; i++)
                {
                    factoriel *= i;
                }
                factorielSum += factoriel;
            }

            if (factorielSum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
