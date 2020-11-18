using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> numbersFirst = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> numbersSecond = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(numbersFirst.Count, numbersSecond.Count); i++)
            {
                result.Add(numbersFirst[i]);
                result.Add(numbersSecond[i]);
            }

            for (int i = Math.Min(numbersFirst.Count, numbersSecond.Count); i < Math.Max(numbersFirst.Count, numbersSecond.Count); i++)
            {
                if (i >= numbersFirst.Count)
                {
                    result.Add(numbersSecond[i]);
                }
                else
                {
                    result.Add(numbersFirst[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
