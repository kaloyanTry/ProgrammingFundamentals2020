using System;
using System.Linq;

namespace CondenseArray
{
    class CondenseArray
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (nums.Length > 1)
            {
                int[] reversedNums = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    reversedNums[i] = nums[i] + nums[i + 1];
                }
                nums = reversedNums;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
