using System;

namespace SumDigits
{
    class DigitsSum
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int result = 0;

            while (num != 0)
            {
                result += num % 10;
                num /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
