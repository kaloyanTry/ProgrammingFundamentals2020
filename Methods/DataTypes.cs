using System;

namespace DataTypesMore
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string input = Console.ReadLine();

            PrintDataTypeResult(inputType, input);
        }

        static void PrintDataTypeResult(string inputType, string input)
        {
            if (inputType == "int")
            {
                int result = int.Parse(input) * 2;
                Console.WriteLine(result);
            }
            else if (inputType == "real")
            {
                double result = double.Parse(input) * 1.5;
                Console.WriteLine($"{result:F2}");
            }
            else if (inputType == "string")
            {
                Console.WriteLine($"${input}$");
            }
        }
    }
}
