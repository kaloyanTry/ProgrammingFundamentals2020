using System;

namespace GreaterValue
{
    class GetGreaterValue
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string output = GetMax(inputType, firstInput, secondInput);
            Console.WriteLine(output);
        }

        static string GetMax(string inputType, string firstInput, string secondInput)
        {
            string result = string.Empty;
            if (inputType == "string")
            {
                if (firstInput.CompareTo(secondInput) >= 0)
                {
                    result = firstInput;
                }
                else
                {
                    result = secondInput;
                }
            }
            else if (inputType == "int")
            {
                int firstNum = int.Parse(firstInput);
                int secondNum = int.Parse(secondInput);
                if (firstNum > secondNum)
                {
                    result = firstInput;
                }
                else
                {
                    result = secondInput;
                }
            }
            else if (inputType == "char")
            {
                char firstChar = char.Parse(firstInput);
                char secondChar = char.Parse(secondInput);
                if (firstChar > secondChar)
                {
                    result = firstInput;
                }
                else
                {
                    result = secondInput;
                }
            }
            return result;
        }
    }
}
