﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class GaussTrick
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse).ToList();

            int midIndex = numbers.Count / 2;

            for (int i = 0; i < midIndex; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);

            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
