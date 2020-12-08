using System;
using System.Text.RegularExpressions;

namespace DigitsLettersOthers
{
    class StringsDigits
    {
        static void Main(string[] args)
        {
            Regex digitRegex = new Regex(@"\d");
            Regex charRegex = new Regex(@"[A-Za-z]");
            Regex otherRegex = new Regex(@"[\W|_]");

            string input = Console.ReadLine();

            string digits = string.Join(string.Empty, digitRegex.Matches(input));
            string chars = string.Join(string.Empty, charRegex.Matches(input));
            string others = string.Join(string.Empty, otherRegex.Matches(input));

            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(others);
        }
    }
}
