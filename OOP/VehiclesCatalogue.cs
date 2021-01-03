using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogueEx
{
    class ProgramVehicles
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();

            while (command != "End")
            {
                string[] commandElements = command.Split().ToArray();

                Vehicle vehicle = new Vehicle(commandElements[0], commandElements[1], commandElements[2], double.Parse(commandElements[3]));


                vehicles.Add(vehicle);
                command = Console.ReadLine();
            }

            string model = Console.ReadLine();
            while (model != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(v => v.Model == model).ToString());

                model = Console.ReadLine();
            }

            var cars = vehicles.FindAll(x => x.Type == "car");
            var carHorsePower = cars.Sum(c => c.HorsePower);
            var carAvrPower = carHorsePower / cars.Count;

            var trucks = vehicles.FindAll(x => x.Type == "truck");
            var trickHorsePower = trucks.Sum(t => t.HorsePower);
            var truckAvrPower = trickHorsePower / trucks.Count;

            if (cars.Count == 0)
            {
                carAvrPower = 0;
            }
            if (trucks.Count == 0)
            {
                truckAvrPower = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {carAvrPower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvrPower:f2}.");
        }

    }
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (Type == "car")
            {
                stringBuilder.AppendLine($"Type: Car");
            }
            else
            {
                stringBuilder.AppendLine($"Type: Truck");
            }

            stringBuilder.AppendLine($"Model: {Model}");
            stringBuilder.AppendLine($"Color: {Color}");
            stringBuilder.AppendLine($"Horsepower: {HorsePower}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
