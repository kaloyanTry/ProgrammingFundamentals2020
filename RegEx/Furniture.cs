using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            Regex regex = new Regex(pattern);
            double sum = 0;

            string input = Console.ReadLine();
            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                Match matches = regex.Match(input);

                if (matches.Success)
                {
                    string name = matches.Groups[1].Value;
                    double price = double.Parse(matches.Groups[2].Value);
                    int quantity = int.Parse(matches.Groups[3].Value);

                    Console.WriteLine(name);

                    sum += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
