using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace EmojiDetector
{
    class EmojiDetector
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternNums = @"\d";
            Regex regexNums = new Regex(patternNums);
            long coolTreshold = 1;
            regexNums.Matches(input).Select(t => t.Value).Select(int.Parse).ToList().ForEach(x => coolTreshold *= x);

            Console.WriteLine($"Cool threshold: {coolTreshold}");

            string patternEmojis = @"(:{2}|\*{2})([A-Z][a-z]{2,})\1";
            Regex regexEmojis = new Regex(patternEmojis);

            var matchesEmojis = regexEmojis.Matches(input);
            int totalEmojis = matchesEmojis.Count;

            List<string> coolEmojis = new List<string>();

            foreach (Match match in matchesEmojis)
            {
                long coolIndex = match.Value.Substring(2, match.Value.Length - 4).ToCharArray().Sum(x => (int)x);

                if (coolIndex >= coolTreshold)
                {
                    coolEmojis.Add(match.Value);
                }
            }

            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");

            foreach (var cool in coolEmojis)
            {
                Console.WriteLine(cool);
            }
        }
    }
}
