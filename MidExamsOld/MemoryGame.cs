using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MemoryGame
{
    class MemoryGame
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            int countMoves = 0;

            while (input != "end")
            {
                string[] tokens = input.Split();
                
                int firstIndex = int.Parse(tokens[0]);
                int secondIndex = int.Parse(tokens[1]);
                countMoves++;

                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < elements.Count && secondIndex < elements.Count && firstIndex != secondIndex)
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");

                        if (firstIndex > secondIndex)
                        {
                            elements.RemoveAt(firstIndex);
                            elements.RemoveAt(secondIndex);
                        }
                        else
                        {
                            elements.RemoveAt(secondIndex);
                            elements.RemoveAt(firstIndex);
                        }

                        if (elements.Count == 0)
                        {
                            Console.WriteLine($"You have won in {countMoves} turns!");
                            return;
                        }
                    }
                    else if (elements[firstIndex] != elements[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    elements.Insert(elements.Count / 2, $"-{countMoves}a");
                    elements.Insert(elements.Count / 2, $"-{countMoves}a");
                    
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
