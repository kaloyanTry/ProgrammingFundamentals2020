using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem02
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"((\*|\@)(?<tag>[A-Z][a-z]{2,})(\*|\@): )(?<first>\[[A-Za-z]\]\|)(?<second>\[[A-Za-z]\]\|)(?<third>\[[A-Za-z]\]\|)$";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success && input.EndsWith(match.Value))
                {
                    string first = match.Groups["first"].Value;
                    string second = match.Groups["second"].Value;
                    string third = match.Groups["third"].Value;
                    int firstInt = 0;
                    int secondInt = 0;
                    int thirdInt = 0;
                    for (int j = 0; j < first.Length; j++)
                    {
                        if (char.IsLetter(first[j]))
                        {
                            firstInt = (int)first[j];
                        }
                    }
                    for (int k = 0; k < second.Length; k++)
                    {
                        if (char.IsLetter(second[k]))
                        {
                            secondInt = (int)second[k];
                        }
                    }
                    for (int l = 0; l < third.Length; l++)
                    {
                        if (char.IsLetter(third[l]))
                        {
                            thirdInt = (int)third[l];
                        }
                    }

                    Console.WriteLine($"{match.Groups["tag"]}: {firstInt} {secondInt} {thirdInt}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
