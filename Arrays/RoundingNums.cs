using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNums
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (double num in nums)
            {
                int numsRounded = (int)Math.Round(num, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{Convert.ToDecimal(num)} => {Convert.ToDecimal(numsRounded)}");
            }
        }
    }
}
