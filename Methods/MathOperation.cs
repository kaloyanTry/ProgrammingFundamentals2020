using System;

namespace MathOperation
{
    class MathOperation
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string numsOperator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = Calculate(firstNum, numsOperator, secondNum);
            
            Console.WriteLine(result);
        }

        static double Calculate(int firstNum, string numsOperator, int secondNum)
        {
            double result = 0.0D;
            
            switch (numsOperator)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
            }

            return result;
        }     
    }
}   
