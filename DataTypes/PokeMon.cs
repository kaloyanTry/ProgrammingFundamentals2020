using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int count = 0;
            double tempPower = 0.5 * power;

            while (power >= distance)
            {
                
                power -= distance;
                count++;

                if (power == tempPower && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
