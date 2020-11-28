using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Lift
{
    class Lift
    {
        static void Main(string[] args)
        {
            
            int tourists = int.Parse(Console.ReadLine());
            int[] wagon = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int touristsOnWagon = 0;
            int touristsOnLift = 0;
            bool isFull = false;

            for (int i = 0; i < wagon.Length; i++)
            {
                while (wagon[i] < 4)
                {
                    wagon[i]++;
                    touristsOnWagon++;
                    if (touristsOnLift + touristsOnWagon == tourists)
                    {
                        isFull = true;
                        break;
                    }
                }
                touristsOnLift += touristsOnWagon;
                if (isFull)
                {
                    break;
                }
                touristsOnWagon = 0;
            }

            if (tourists > touristsOnLift)
            {
                Console.WriteLine($"There isn't enough space! {tourists - touristsOnLift} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (tourists < wagon.Length * 4 && wagon.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (wagon.All(w => w == 4) && isFull == true)
            {
                Console.WriteLine(string.Join(" ", wagon));
            }
        }
    }
}
