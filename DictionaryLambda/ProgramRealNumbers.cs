using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class ProgramRealNumbers
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().
                Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var number in inputNumbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
