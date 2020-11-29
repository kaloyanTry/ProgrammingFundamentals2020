using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Race
{
    class Race
    {
        static void Main(string[] args)
        {
            string[] listOfNames = Console.ReadLine().Split(", ");
            Dictionary<string, int> dictionaryOfNames = new Dictionary<string, int>();

            foreach (var name in listOfNames)
            {
                dictionaryOfNames.Add(name, 0);
            }

            string patternName = @"[\W\d]";
            string patternNumber = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, patternName, string.Empty);
                string distance = Regex.Replace(input, patternNumber, string.Empty);
                int sum = 0;

                foreach (var digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;
                }

                if (dictionaryOfNames.ContainsKey(name))
                {
                    dictionaryOfNames[name] += sum;
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var kvp in dictionaryOfNames.OrderByDescending(k => k.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count++}{text} place: {kvp.Key}");

                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
