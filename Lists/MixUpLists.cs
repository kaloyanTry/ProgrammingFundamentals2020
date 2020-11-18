using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace MixedUpLists
{
    class MixUpLists
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> maxList = new List<int>();
            List<int> reminders = new List<int>(2);
            List<int> mixedList = new List<int>();

			if (firstList.Count > secondList.Count)
			{
				maxList = firstList;
			}
			else
			{
				maxList = secondList;
				maxList.Reverse();
			}
			for (int i = maxList.Count - 2; i < maxList.Count; i++)
			{
				reminders.Add(maxList[i]);
			}
			reminders.Sort();
			if (firstList.Count > secondList.Count)
			{
				firstList.RemoveRange(firstList.Count - 2, 2);
				secondList.Reverse();
			}
			else
			{
				secondList.RemoveRange(secondList.Count - 2, 2);
				secondList.Reverse();
			}
			for (int i = 0; i < firstList.Count; i++)
			{
				mixedList.Add(firstList[i]);
				mixedList.Add(secondList[i]);
			}
			List<int> output = mixedList.FindAll(x => x > reminders[0] && x < reminders[1]);
			output.Sort();
			Console.WriteLine(string.Join(" ", output));
		}
    }
}
