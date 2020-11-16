using System;
using System.Collections.Generic;
using System.Linq;

namespace FilteredWords
{
    class WordFilter
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split()
                .Where(w => w.Length % 2 == 0).ToList();

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }

        }
    }
}
