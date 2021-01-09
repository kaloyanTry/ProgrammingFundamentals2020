using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resoursesList = new Dictionary<string, int>();
          
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());
                
                if (resoursesList.ContainsKey(resource))
                {
                    resoursesList[resource] += quantity;
                }
                else
                {
                    resoursesList.Add(resource, quantity);
                }
            }

            foreach (var pair in resoursesList)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
