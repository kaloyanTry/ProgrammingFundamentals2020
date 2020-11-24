using System;
using System.Linq;

namespace Largest3Numbers
{
    class LargestNums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] orderedNumbers = numbers.OrderByDescending(n => n).Take(3).ToArray();

            Console.Write(string.Join(" ", orderedNumbers));
        }
    }
}
