using System;
using System.Linq;

namespace EqualArrays
{
    class EqualArrays
    {
        static void Main(string[] args)
        {
            int[] numsFirstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numsSecondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < numsFirstArray.Length; i++)
            {
                if (numsFirstArray[i] != numsSecondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            sum = numsFirstArray.Sum();

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
