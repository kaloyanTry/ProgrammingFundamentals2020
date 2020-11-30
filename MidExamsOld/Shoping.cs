using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.EasterShoping
{
    class Shoping
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();
            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numCommands; i++)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split();
                string command = commands[0];

                switch (command)
                {
                    case "Include":
                        string shopInclude = commands[1];
                        shops.Add(shopInclude);
                        break;

                    case "Visit":
                        string commandDirection = commands[1];
                        int numberOfShops = int.Parse(commands[2]);
                        if (commandDirection == "first")
                        {
                            if (numberOfShops <= shops.Count)
                            {
                                shops.RemoveRange(0, numberOfShops);
                            }
                        }
                        if (commandDirection == "last")
                        { 
                            if (numberOfShops <= shops.Count)
                            {
                                shops.RemoveRange(shops.Count - numberOfShops, numberOfShops);
                            }
                        }
                        break;

                    case "Prefer":
                        int indexFirstShop = int.Parse(commands[1]);
                        int indexSecondShop = int.Parse(commands[2]);
                        if ((indexFirstShop >= 0 && indexFirstShop < shops.Count) && (indexSecondShop >= 0 && indexSecondShop < shops.Count))
                        {
                            string temp1 = shops[indexFirstShop];
                            string temp2 = shops[indexSecondShop];
                            shops[indexFirstShop] = temp2;
                            shops[indexSecondShop] = temp1;
                        }
                        break;

                    case "Place":
                        string shopPlace = commands[1];
                        int shopIndexPlace = int.Parse(commands[2]);
                        if (shopIndexPlace >= 0 && shopIndexPlace < shops.Count - 1)
                        {
                            shops.Insert(shopIndexPlace + 1, shopPlace);
                        }
                        break;
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
