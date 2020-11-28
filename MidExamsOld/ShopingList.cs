using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ShopingList
{
    class ShopingList
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine().Split("!").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commands = input.Split().ToArray();

                string command = commands[0];
                string item = commands[1];

                switch (command)
                {
                    case "Urgent":
                        if (!initialList.Contains(item))
                        {
                            initialList.Insert(0, item);
                        }
                        break;

                    case "Unnecessary":
                        if (initialList.Contains(item))
                        {
                            initialList.Remove(item);
                        }
                        break;
                    case "Correct":
                        if (initialList.Contains(item))
                        {
                            int index = initialList.IndexOf(item);
                            string itemNew = commands[2];
                            initialList.Insert(index, itemNew);
                            initialList.RemoveAt(index + 1);
                        }
                        break;
                    case "Rearrange":
                        if (initialList.Contains(item))
                        {
                            initialList.Remove(item);
                            initialList.Add(item);
                        }
                        break;
                }
            }
            Console.Write(string.Join(", ", initialList));
        }
    }
}