using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogueEx
{
    class VehiclesCatalogueExercise
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputData = input.Split();
                string type = inputData[0];
                string model = inputData[1];
                string color = inputData[2];
                int horsePower = int.Parse(inputData[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            string modelPrint = Console.ReadLine();
            while (modelPrint != "Close the Catalogue")
            {
                string modelString = vehicles.FirstOrDefault(v => v.Model == modelPrint).ToString();

                Console.WriteLine(modelString);

                modelPrint = Console.ReadLine();
            }

            List<Vehicle> cars = vehicles.FindAll(c => c.Type == "car");
            double carHorsePower = cars.Sum(c => c.HorsePower);
            double carAveragePower = carHorsePower / cars.Count;

            List<Vehicle> trucks = vehicles.FindAll(t => t.Type == "truck");
            double truckHorsePower = trucks.Sum(t => t.HorsePower);
            double truckAveragePower = truckHorsePower / trucks.Count;

            if (cars.Count == 0)
            {
                carAveragePower = 0;
            }
            if (trucks.Count == 0)
            {
                truckAveragePower = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {carAveragePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAveragePower:f2}.");
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Type == "car")
            {
                sb.AppendLine("Type: Car");
            }
            else if (Type == "truck")
            {
                sb.AppendLine("Type: Truck");
            }

            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}