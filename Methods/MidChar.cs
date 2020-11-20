using System;
using System.Linq;

namespace MiddleChar
{
    class MidChar
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = ReturnMidChar(input);
            Console.WriteLine(result);

        }

        private static string ReturnMidChar(string input)
        {
            string midChar = string.Empty;

            if (input.Length % 2 == 1)
            {
                midChar = input[input.Length / 2].ToString();
            }
            else
            {
                midChar = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            return midChar;
        }
    }
}
