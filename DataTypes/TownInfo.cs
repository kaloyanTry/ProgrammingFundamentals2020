using System;

namespace TownInfo
{
    class TownInfo
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            int populationOfTown = int.Parse(Console.ReadLine());
            int areaOfTown = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {populationOfTown} and area {areaOfTown} square km.");
        }
    }
}
