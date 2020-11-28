using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.EasterGifts
{
    class Gifts
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            while (input != "No Money")
            {
                string[] commands = input.Split();
                string command = commands[0];
                string requiredGift = commands[1];

                switch (command)
                {
                    case "OutOfStock":
                        if (gifts.Contains(requiredGift))
                        {
                            for (int i = 0; i < gifts.Count; i++)
                            {
                                if (gifts[i] == requiredGift)
                                {
                                    gifts[i] = "None";
                                }
                            }
                        }
                        break;

                    case "Required":
                        int index = int.Parse(commands[2]);
                        if (index >= 0 && index <= gifts.Count)
                        {
                            gifts[index] =  requiredGift;
                        }
                        break;

                    case "JustInCase":
                        gifts[gifts.Count - 1] = requiredGift;
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var item in gifts)
            {
                if (item != "None")
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
