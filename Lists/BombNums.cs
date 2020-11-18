using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNums
    {
        static void Main(string[] args)
        {
            List<int> numsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specBombNum = bombNums[0];
            int bombPower = bombNums[1];

            int bombIndex = numsList.IndexOf(specBombNum);

            while (bombIndex != -1)
            {
                int leftNums = bombIndex - bombPower;
                int rightNums = bombIndex + bombPower;

                if (leftNums < 0 )
                {
                    leftNums = 0;
                }
                if (rightNums > numsList.Count - 1)
                {
                    rightNums = numsList.Count - 1;
                }

                numsList.RemoveRange(leftNums, (rightNums - leftNums + 1));

                bombIndex = numsList.IndexOf(specBombNum);
            }

            int sum = numsList.Sum();

            Console.WriteLine(sum);
        }
    }
}
