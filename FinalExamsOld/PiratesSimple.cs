using System;
using System.Collections.Generic;
using System.Linq;

namespace PiratesSimpleSolution
{
    class PiratesSimple
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (true)
            {
                string city = Console.ReadLine();

                if (city == "Sail")
                {
                    break;
                }

                string[] cmdArgs = city.Split("||");
                string town = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                if (cities.ContainsKey(town))
                {
                    cities[town][0] += population;
                    cities[town][1] += gold;
                }
                else
                {
                    cities.Add(town, new List<int> { population, gold });
                }
            }

            while (true)
            {
                string events = Console.ReadLine();

                if (events == "End")
                {
                    break;
                }

                string[] cmdArgs = events.Split("=>");

                if (cmdArgs[0] == "Plunder")
                {
                    string town = cmdArgs[1];
                    int population = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);

                    cities[town][0] -= population;
                    cities[town][1] -= gold;

                    if (cities[town][0] >= 0 && cities[town][1] >= 0)
                    {
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");

                        if (cities[town][0] == 0 || cities[town][1] == 0)
                        {
                            cities.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                    }
                }
                else if (cmdArgs[0] == "Prosper")
                {
                    string town = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);

                    if (gold > 0)
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }
            }

            if (cities.Count != 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities.OrderByDescending(x => x.Value[1]).ThenBy(k => k.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}