using System;

namespace ReverseString
{
    class ReverseStr
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            Console.WriteLine(result);
        }
    }
}
