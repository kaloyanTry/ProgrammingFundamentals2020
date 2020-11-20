using System;
using System.Linq;

namespace Palindrome_Integers
{
    class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string inputNum)
        {
            char[] reversedInput = inputNum.Reverse().ToArray();

            for (int i = 0; i < inputNum.Length; i++)
            {
                if (!(reversedInput[i] == inputNum[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
