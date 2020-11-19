using System;
using System.Linq;

namespace ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numsFirst = new int[n];
            int[] numsSecond = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        numsFirst[i] = nums[1];
                        numsSecond[i] = nums[0];
                    }
                    else
                    {
                        numsFirst[i] = nums[0];
                        numsSecond[i] = nums[1];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numsFirst));
            Console.WriteLine(string.Join(" ", numsSecond));
        }
    }
}
