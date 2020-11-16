using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Chalenger
{
    class MOBA
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> statistics = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] inputArr = input.Split(" -> ");
                    string playerName = inputArr[0];
                    string position = inputArr[1];
                    int skill = int.Parse(inputArr[2]);

                    if (!statistics.ContainsKey(playerName))
                    {
                        statistics.Add(playerName, new Dictionary<string, int>());
                    }

                    if (!statistics[playerName].ContainsKey(position))
                    {
                        statistics[playerName].Add(position, 0);
                    }

                    if (statistics[playerName][position] < skill)
                    {
                        statistics[playerName][position] = skill;
                    }

                }
                else if (input.Contains(" vs "))
                {
                    string[] inputArr = input.Split(" vs ");
                    string firstPlayer = inputArr[0];
                    string secondPlayer = inputArr[1];

                    if (statistics.ContainsKey(firstPlayer) && statistics.ContainsKey(secondPlayer))
                    {
                        foreach (var position in statistics[firstPlayer].Keys)
                        {
                            if (statistics[secondPlayer].ContainsKey(position))
                            {
                                if (statistics[firstPlayer].Values.Sum() > statistics[secondPlayer].Values.Sum())
                                {
                                    statistics.Remove(secondPlayer);
                                }
                                else if (statistics[secondPlayer].Values.Sum() > statistics[firstPlayer].Values.Sum())
                                {
                                    statistics.Remove(firstPlayer);
                                }
                                break;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in statistics.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var pl in player.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {pl.Key} <::> {pl.Value}");
                }

            }

        }
    }
}