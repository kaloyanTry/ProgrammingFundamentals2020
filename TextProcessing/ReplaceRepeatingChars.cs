using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class ReplaceREpeatingChars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputChars = input.ToCharArray();

            List<char> result = new List<char>();
            
            result.Add(input[0]);

            foreach (var ch in inputChars)
            {
                if (ch != result.Last())
                {
                    result.Add(ch);
                }
            }

            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
