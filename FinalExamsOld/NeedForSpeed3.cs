using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed
{
    class NeedForSpeed3
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputCars = Console.ReadLine().Split('|');
                string name = inputCars[0];
                int mileage = int.Parse(inputCars[1]);
                int fuel = int.Parse(inputCars[2]);

                Car car = new Car() { Mileage = mileage, Fuel = fuel };
                cars.Add(name, car);
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] inputCommands = input.Split(" : ");
                string command = inputCommands[0];
                string car = inputCommands[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(inputCommands[2]);
                    int fuelDrive = int.Parse(inputCommands[3]);

                    if (cars[car].Fuel - fuelDrive > 0)
                    {
                        cars[car].Fuel -= fuelDrive;
                        cars[car].Mileage += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuelDrive} liters of fuel consumed.");

                        if (cars[car].Mileage > 100000)
                        {
                            cars.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (command == "Refuel")
                {
                    int fuelRefuel = int.Parse(inputCommands[2]);
                    if (cars[car].Fuel + fuelRefuel > 75)
                    {
                        fuelRefuel = 75 - cars[car].Fuel;
                    }
                    cars[car].Fuel += fuelRefuel;

                    Console.WriteLine($"{car} refueled with {fuelRefuel} liters");
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(inputCommands[2]);
                    cars[car].Mileage -= kilometers;
                    if (cars[car].Mileage < 10000)
                    {
                        cars[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
                input = Console.ReadLine();
            }

            var sortedCars = cars.OrderByDescending(c => c.Value.Mileage).ThenBy(c => c.Key);

            foreach (var car in sortedCars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }

    class Car
    {
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
