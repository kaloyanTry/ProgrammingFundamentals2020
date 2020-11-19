using System;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int passengersTotal = 0;
            int[] passengersInWagon = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                int passengers = int.Parse(Console.ReadLine());

                passengersInWagon[i] = passengers;

                passengersTotal += passengers;
            }

            Console.WriteLine(string.Join(" ", passengersInWagon));
            Console.WriteLine(passengersTotal);
        }
    }
}
