using System;
using System.Numerics;

namespace SnowBalls
{
    class SnowBalls
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            BigInteger biggestValue = 0;
            int biggestSnowBallSnow = 0;
            int bigestSnowBallTime = 0;
            int bigestSnowBallQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowBallsSnow = int.Parse(Console.ReadLine());
                int snowBallsTime = int.Parse(Console.ReadLine());
                int snowBallsQuality = int.Parse(Console.ReadLine());

                int snowDevByTime = snowBallsSnow / snowBallsTime;

                BigInteger snowBallsValue = BigInteger.Pow(snowDevByTime, snowBallsQuality);

                if (snowBallsValue > biggestValue)
                {
                    biggestValue = snowBallsValue;
                    biggestSnowBallSnow = snowBallsSnow;
                    bigestSnowBallTime = snowBallsTime;
                    bigestSnowBallQuality = snowBallsQuality;
                }
            }
            Console.WriteLine($"{biggestSnowBallSnow} : {bigestSnowBallTime} =" + $" {biggestValue} ({bigestSnowBallQuality})");
        }
    }
}
