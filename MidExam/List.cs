using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class List
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;
            int countBlackNames = 0;
            int countLostNames = 0;

            while ((input = Console.ReadLine()) != "Report")          
            {
                string[] commands = input.Split();
                string command = commands[0];

                switch (command)
                {
                    case "Blacklist":
                        string name = commands[1];
                        if (friends.Contains(name))
                        {
                            int index = friends.IndexOf(name);
                            friends[index] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");

                            countBlackNames++;
                        }
                        else
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        break;

                    case "Error":
                        int indexError = int.Parse(commands[1]);
                        if ((friends[indexError] != "Blacklisted") && (friends[indexError] != "Lost"))
                        {
                            string oldName = friends[indexError];
                            friends[indexError] = "Lost";
                            Console.WriteLine($"{oldName} was lost due to an error.");                        
                            countLostNames++;
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    case "Change":
                        int indexChange = int.Parse(commands[1]);
                        string newName = commands[2];
                        if (indexChange >= 0 && indexChange < friends.Count)
                        {
                            string tempName = friends[indexChange];
                            friends[indexChange] = newName;
                            Console.WriteLine($"{tempName} changed his username to {newName}.");   
                        }
                        else
                        {
                            continue;
                        }
                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {countBlackNames}");
            Console.WriteLine($"Lost names: {countLostNames}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
