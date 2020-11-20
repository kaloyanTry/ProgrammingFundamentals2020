using System;
using System.Numerics;

namespace FactorialDivision
{
    class FacDiv
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = CalculateFactorial(num1) / CalculateFactorial(num2);
            Console.WriteLine($"{result:F2}");

            static decimal CalculateFactorial(int num)
            {
                decimal factoralNum = 1;
                for (int i = num; i > 1; i--)
                {
                    factoralNum *= i;
                }
                return factoralNum;
            }

        }
    }
}
