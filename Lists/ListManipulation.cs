using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ListManipulation
{
    class ListManipulation
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                
                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
