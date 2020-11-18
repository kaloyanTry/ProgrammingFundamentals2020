using System;

namespace FloatingEquality
{
    class FloatingNumsEquals
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            double diffNumbers = Math.Abs(firstNumber - secondNumber);

            bool isEqual = diffNumbers < eps;
            
            Console.WriteLine(isEqual);
        }
    }
}
