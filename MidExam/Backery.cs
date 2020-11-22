using System;

namespace MidExam
{
    class Backery
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactoryPerMonth = int.Parse(Console.ReadLine());

            int totalPerDay = biscuitsPerDay * workers;
            int totalBiscuits = 0;
            int day = 0;

            for (int i = 0; i < 30; i++)
            {
                day++;
                
                if (day % 3 == 0)
                {
                    int thirdDay = (int)Math.Floor(totalPerDay * 0.75);
                    totalBiscuits += thirdDay;
                }
                else
                {
                    totalBiscuits += totalPerDay;
                }       
            }

            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

            int totalDiff = totalBiscuits - competingFactoryPerMonth;

            double percentage = (double)Math.Abs(totalDiff) / (double)competingFactoryPerMonth * 100;

            if (totalBiscuits > competingFactoryPerMonth)
            {
                Console.WriteLine($"You produce {percentage:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:F2} percent less biscuits.");
            }
        }
    }
}