using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double avrNumbers = numbers.Average();

            List<int> result = numbers.OrderByDescending(x => x).Where(x => x > avrNumbers).Take(5).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.Write(string.Join(" ", result));
            }    
        }
    }
}
