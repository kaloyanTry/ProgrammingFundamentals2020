using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _3.HeartDelivery
{
    class CupidHearts
    {
        static void Main(string[] args)
        {
            int[] neiborhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            int jumpPosition = 0;
            string command = Console.ReadLine();

            while (command != "Love!")
            {
                string[] commands = command.Split();
                int jumpLength = int.Parse(commands[1]);

                jumpPosition += jumpLength;

                if (jumpPosition >= 0 && jumpPosition < neiborhood.Length)
                {
                    neiborhood[jumpPosition] -= 2;
                }
                else
                {
                    jumpPosition = 0;
                    neiborhood[jumpPosition] -= 2;
                }

                if (neiborhood[jumpPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpPosition} has Valentine's day.");
                }
                else if (neiborhood[jumpPosition] < 0)
                {
                    Console.WriteLine($"Place {jumpPosition} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {jumpPosition}.");

            int failedCount = neiborhood.Count(x => x > 0);

            if (failedCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedCount} places.");
            }
        }
    }
}
