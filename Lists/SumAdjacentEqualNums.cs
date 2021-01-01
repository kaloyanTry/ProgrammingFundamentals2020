using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();
            
            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(double.Parse(list[i]));
            }
            
            int index = 0;
            
            while (index < numbers.Count - 1)
            {
                if (numbers[index] == numbers[index + 1])
                {
                    numbers[index] = numbers[index] + numbers[index + 1];
                    numbers.RemoveAt(index + 1);
                    if (index > 0) 
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
