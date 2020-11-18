using System;
using System.Collections.Generic;
using System.Linq;

namespace CarsRace
{
    class Race
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            double totalTimeLeft = 0;
            double totalTimeRight = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                totalTimeLeft += numbers[i];
                if (numbers[i] == 0)
                {
                    totalTimeLeft *= 0.8;
                }     
            }   

            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                totalTimeRight += numbers[i];
                if (numbers[i] == 0)
                {
                    totalTimeRight *= 0.8;
                }   
            }

            if (totalTimeLeft <= totalTimeRight)
            {
                Console.WriteLine($"The winner is left with total time: {totalTimeLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {totalTimeRight}");
            }
        }
    }
}
