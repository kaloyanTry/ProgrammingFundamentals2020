using System;
using System.Text.RegularExpressions;

namespace SoftUniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";

            Regex regex = new Regex(pattern);
            double totalIncome = 0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                Match matches = regex.Match(input);

                if (matches.Success)
                {
                    string customer = matches.Groups[1].Value;
                    string product = matches.Groups[2].Value;
                    int count = int.Parse(matches.Groups[3].Value);
                    double price = double.Parse(matches.Groups[4].Value);

                    double sum = count * price;
                    totalIncome += sum;

                    Console.WriteLine($"{customer}: {product} - {sum:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
