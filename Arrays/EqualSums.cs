using System;
using System.Linq;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isEqual = false;

            if (nums.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int l = 0; l < i; l++)
                {
                    leftSum += nums[l];
                }

                for (int r = i + 1; r < nums.Length; r++)
                {
                    rightSum += nums[r];
                }

                
                if (leftSum == rightSum)
                {
                    isEqual = true;
                    Console.WriteLine(i);
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
