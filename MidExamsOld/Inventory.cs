using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Inventory
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] commands = input.Split(" - ");
                string command = commands[0];
                string item = commands[1];

                switch (command)
                {
                    case "Collect":
                        if (!items.Contains(item))
                        {
                            items.Add(item);
                        }
                        break;

                    case "Drop":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                        }
                        break;

                    case "Combine Items":
                        string[] combinedItems = item.Split(":");
                        string oldItem = combinedItems[0];
                        string newItem = combinedItems[1];
                        
                        if (items.Contains(oldItem))
                        {
                            int index = items.IndexOf(oldItem);
                            items.Insert(index + 1, newItem);
                        }
                        break;

                    case "Renew":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                            items.Add(item);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
