using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VihicleCatalogue
{
    class ProgramCatalogue
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            Catalogue collection = new Catalogue();

            while (input != "end")
            {
                string[] tokens = input.Split("/");
                string typeVehicle = tokens[0];
                
                if (typeVehicle == "Car")
                {
                    string carBrand = tokens[1];
                    string carModel = tokens[2];
                    int carHorsePower = int.Parse(tokens[3]);

                    Car car = new Car(carBrand, carModel, carHorsePower);

                    collection.CarsCatalogue.Add(car);
                }
                else if (typeVehicle == "Truck")
                {
                    string truckBrand = tokens[1];
                    string truckModel = tokens[2];
                    int truckWeight = int.Parse(tokens[3]);

                    Truck truck = new Truck(truckBrand, truckModel, truckWeight);

                    collection.TrucksCatalogue.Add(truck);
                }
                input = Console.ReadLine();
            }
            Console.Write(collection.ToString());
        }
    }
    class Truck
    {
        public string TruckBrand { get; set; }
        public string TruckModel { get; set; }
        public int TruckWeight { get; set; }

        public Truck(string truckBrand, string truckModel, int truckWeight)
        {
            TruckBrand = truckBrand;
            TruckModel = truckModel;
            TruckWeight = truckWeight;
        }
        public override string ToString()
        {
            return $"{TruckBrand}: {TruckModel} - {TruckWeight}kg";
        }
    }
    class Car
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarHorsePower { get; set; }

        public Car(string carBrand, string carModel, int carHorsePower)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            CarHorsePower = carHorsePower;
        }

        public override string ToString()
        {
            return $"{CarBrand}: {CarModel} - {CarHorsePower}hp";
        }
    }
    class Catalogue
    { 
        public List<Car> CarsCatalogue { get; set; }
        public List<Truck> TrucksCatalogue { get; set; }

        public Catalogue()
        {
            CarsCatalogue = new List<Car>();
            TrucksCatalogue = new List<Truck>();
        }

        public override string ToString()
        {
            List<Car> orderedCars = CarsCatalogue.OrderBy(c => c.CarBrand).ToList();
            List<Truck> orderedTrucks = TrucksCatalogue.OrderBy(t => t.TruckBrand).ToList();

            StringBuilder sbCatalogue = new StringBuilder();

            if (orderedCars.Count  > 0)
            {
                sbCatalogue.AppendLine("Cars:");
                foreach (var car in orderedCars)
                {
                    sbCatalogue.AppendLine(car.ToString());
                }
            }
            if (orderedTrucks.Count > 0)
            {
                sbCatalogue.AppendLine("Trucks:");
                foreach (var truck in orderedTrucks)
                {
                    sbCatalogue.AppendLine(truck.ToString());
                }
            }
            return sbCatalogue.ToString();
        }
    }
}
