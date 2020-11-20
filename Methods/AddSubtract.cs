using System;

namespace AddSubtract
{
    class AddSubtract
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sumResult = SumTwoNums(num1, num2);
            int subResult = Subtract(sumResult, num3);
            Console.WriteLine(subResult);

        }


        static int SumTwoNums(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        private static int Subtract(int sumResult, int num3)
        {
            int result = sumResult - num3;
            return result;
        }
    }
}
