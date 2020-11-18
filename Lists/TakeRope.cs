using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakeSkipRope
{
    class TakeRope
    {
        static void Main(string[] args)
        {
            string inputMsg = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<string> nonNumbers = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < inputMsg.Length; i++)
            {
                if (char.IsDigit(inputMsg[i]))
                {
                    numbers.Add(int.Parse(inputMsg[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(inputMsg[i].ToString());
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }

            }

            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(nonNumbers);

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

                result.Append(string.Join("", temp));

                indexForSkip += takeList[i] + skipList[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
