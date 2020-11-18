using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class TrainAddPassengers
    {
        static void Main(string[] args)
        {
            List<int> passengersPerWagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputElements = input.Split();

                if (inputElements[0] == "Add")
                {
                    int passengers = int.Parse(inputElements[1]);
                    passengersPerWagon.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(input);
                    for (int i = 0; i < passengersPerWagon.Count; i++)
                    {
                        if (passengersPerWagon[i] + passengers <= wagonCapacity)
                        {
                            passengersPerWagon[i] += passengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', passengersPerWagon));
        }
    }
}
