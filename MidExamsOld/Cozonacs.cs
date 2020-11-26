using System;

namespace _1.EasterCozonacs
{
    class Cozonacs
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            double priceFloor = double.Parse(Console.ReadLine());
            double pricePackEggs = priceFloor * 0.75;
            double priceMilk = priceFloor * 1.25;
            int countOfCozonacs = 0;
            int coloredEggs = 0;

            double priceOneCozonac = priceFloor + pricePackEggs + (priceMilk / 4);

            while(boudget >= priceOneCozonac)
            {
                boudget -= priceOneCozonac;
                countOfCozonacs++;
                coloredEggs += 3;

                if (countOfCozonacs % 3 == 0)
                {
                    int lostEggs = countOfCozonacs - 2;
                    coloredEggs -= lostEggs;
                }
            }

            Console.WriteLine($"You made {countOfCozonacs} cozonacs! Now you have {coloredEggs} eggs and {boudget:f2}BGN left.");
        }
    }
}