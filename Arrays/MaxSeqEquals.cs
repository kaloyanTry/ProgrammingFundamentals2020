using System;
using System.Linq;

namespace MaxSequenceEqualElements
{
    class MaxSeqEquals
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int maxSequence = 0;
            int indexSequence = 0;
            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int countSequence = 0;
                int iNum = i;

                while (nums[i] == nums[iNum])
                {
                    countSequence++;
                    iNum++;

                    if (iNum >= nums.Length)
                    {
                        break;
                    }
                }

                if (countSequence > maxSequence)
                {
                    maxSequence = countSequence;
                    indexSequence = i;
                }
            }

            for (int i = indexSequence; i <= indexSequence + maxSequence - 1; i++)
            {
                if (i != indexSequence + maxSequence - 1)
                {
                    Console.Write($"{nums[i]} ");
                }
                else
                {
                    Console.Write(nums[i]);
                }
            }
        }
    }
}
