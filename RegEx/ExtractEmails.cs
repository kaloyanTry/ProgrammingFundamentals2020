using System;
using System.Text.RegularExpressions;

namespace ExractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            Regex emailsRegex = new Regex(@"(\s[a-z]+[\w.-]+\w)@([a-z]+[-a-z]*?([.][a-z]+)+)\b");

            string input = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine, emailsRegex.Matches(input)));
        }
    }
}
