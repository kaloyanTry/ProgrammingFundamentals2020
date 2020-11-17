using System;

namespace GamingStore
{
    class GameStore
    {
        static void Main(string[] args)
        {
            double inputBalance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double gamePrice = 0;
            double currentBalance = inputBalance;

            while (command != "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        command = Console.ReadLine();
                        continue;
                }
                if (gamePrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    gamePrice = 0;
                    command = Console.ReadLine();
                    continue;
                }

                currentBalance -= gamePrice;

                if (currentBalance >= 0)
                {
                    Console.WriteLine($"Bought {command}");
                }

                if (currentBalance < 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                command = Console.ReadLine();
            }

            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${(inputBalance - currentBalance):F2}. Remaining: ${(currentBalance):F2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
