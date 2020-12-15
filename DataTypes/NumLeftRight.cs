using System;
using System.Diagnostics;

namespace FromLeftToRight
{
    class NumLeftRight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string stringOfNums = Console.ReadLine();

                char delimiter = (' ');
                string[] splitNums = stringOfNums.Split(delimiter);

                long leftNum = long.Parse(splitNums[0]);
                long rightNum = long.Parse(splitNums[1]);
                long biggerNum = leftNum;
                
                if (rightNum > leftNum)
                {
                    biggerNum = rightNum;
                }

                long sumOfDigits = 0;
                
                while (biggerNum != 0)
                {
                    sumOfDigits += biggerNum % 10;
                    biggerNum /= 10;
                }
                
                Console.WriteLine(Math.Abs(sumOfDigits));
            }
        }
    }
}
