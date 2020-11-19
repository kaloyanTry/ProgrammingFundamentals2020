using System;

namespace NumsInReversedOrder
{
    class ReversedNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            int[] numsReversed = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                numsReversed[nums.Length - i - 1] = nums[i];
            }
            
            Console.Write(string.Join(" ", numsReversed));
        }
    }
}
