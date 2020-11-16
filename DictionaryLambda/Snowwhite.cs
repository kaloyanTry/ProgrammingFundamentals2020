using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> drawfs = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] inputData = input.Split(" <:> ");
                string name = inputData[0];
                string hairColor = inputData[1];
                int physics = int.Parse(inputData[2]);

                string key = $"({hairColor}) {name}";

                if (!drawfs.ContainsKey(key))
                {
                    drawfs.Add(key, 0);
                }

                if (drawfs[key] < physics)
                {
                    drawfs[key] = physics;
                }

                input = Console.ReadLine();
            }

            foreach (var drawf in drawfs.OrderByDescending(d => d.Value)
    .ThenByDescending(c => drawfs.Where(d => d.Key.Split(")")[0] == c.Key.Split(")")[0]).Count()))
            {
                Console.WriteLine($"{drawf.Key} <-> {drawf.Value}");
            }
        }
    }
}
