using System;
using System.Collections.Generic;

namespace ConsoleAssociative
{
    class ProgramAssociative
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> fruits = new SortedDictionary<string, double>();

            fruits.Add("banana", 2.20);
            fruits.Add("kiwi", 1.30);

            foreach (var item in fruits)
            {
                Console.WriteLine($"the pice of {item.Key} is {item.Value}");
            }
        }
    }
}
