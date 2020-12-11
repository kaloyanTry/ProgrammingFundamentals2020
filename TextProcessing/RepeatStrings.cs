using System;
using System.Text;

namespace RepeatStrings
{
    class RepeatStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split();
            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                int countChars = word.Length;
                for (int i = 0; i < countChars; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}
