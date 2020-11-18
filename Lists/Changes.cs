using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeLists
{
    class Changes
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandElements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandElements[0] == "Delete")
                {
                    numbers.RemoveAll(n => n == int.Parse(commandElements[1]));
                }

                if (commandElements[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commandElements[2]), int.Parse(commandElements[1]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
