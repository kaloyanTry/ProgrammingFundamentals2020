using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class AdAstra
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)(?<item>[A-Za-z\s]+)(\1)(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})(\1)(?<calories>[0-9]{1,5})(\1)";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();
            int totalCalories = 0;

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                int currCalories = int.Parse(match.Groups["calories"].Value);
                totalCalories += currCalories;
            }

            int days = totalCalories / 2000;
            
            Console.WriteLine($"You have food to last you for: {days} days!");
            
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["item"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
