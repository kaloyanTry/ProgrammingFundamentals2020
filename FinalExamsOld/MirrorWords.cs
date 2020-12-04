using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class MirrorWords
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<string> mirrorWords = new List<string>();
            string pattern = @"(@|#)(?<first>[A-Za-z]{3,})(\1)(\1)(?<second>[A-Za-z]{3,})(\1)";
            Regex regexWords = new Regex(pattern);

            MatchCollection matchedWords = regexWords.Matches(text);
            int matchCounter = 0;

            foreach (Match match in matchedWords)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["first"].Value;
                    string secondWord = match.Groups["second"].Value;
                    char[] secondChar = secondWord.ToCharArray();
                    Array.Reverse(secondChar);
                    string secondReversed = new string(secondChar);

                    if (firstWord == secondReversed)
                    {
                        string mirror = firstWord + " <=> " + secondWord;
                        mirrorWords.Add(mirror);
                    }
                    matchCounter++;
                }
            }

            if (matchedWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matchCounter} word pairs found!");
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
