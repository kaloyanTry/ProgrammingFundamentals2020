using System;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(i, words.Length);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
