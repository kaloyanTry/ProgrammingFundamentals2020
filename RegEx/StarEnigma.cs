using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace StarEnigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            Regex decriptionRegex = new Regex(@"[SsTtAaRr]");
            Regex pattern = new Regex(@"@([A-Z][a-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([A|D])![^@\-!:>]*->(\d+)");

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int decryptionKey = decriptionRegex.Matches(input).Count;

                string decrypted = string.Empty;
                for (int j = 0; j < input.Length; j++)
                {
                    decrypted += (char)(input[j] - decryptionKey);
                }

                if (pattern.IsMatch(decrypted))
                {
                    string planetName = pattern.Match(decrypted).Groups[1].ToString();
                    char attackedType = char.Parse(pattern.Match(decrypted).Groups[3].ToString());

                    if (attackedType == 'A')
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackedType == 'D')
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets.OrderBy(p => p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(p => p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
