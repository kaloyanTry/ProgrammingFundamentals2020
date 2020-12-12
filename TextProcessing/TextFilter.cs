using System;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    string replace = new string('*', word.Length);

                    text = text.Replace(word, replace);
                }
            }

            Console.WriteLine(text);
        }
    }
}
