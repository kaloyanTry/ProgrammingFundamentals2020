using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> dragonArmy = new Dictionary<string, Dictionary<string, int[]>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                string type = inputData[0];
                string name = inputData[1];
                string damageAsStr = inputData[2];
                string healthAsStr = inputData[3];
                string armorAsStr = inputData[4];

                if (damageAsStr == "null")
                {
                    damageAsStr = "45";
                }

                if (healthAsStr == "null")
                {
                    healthAsStr = "250";
                }

                if (armorAsStr == "null")
                {
                    armorAsStr = "10";
                }

                int damage = int.Parse(damageAsStr);
                int health = int.Parse(healthAsStr);
                int armor = int.Parse(armorAsStr);

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new Dictionary<string, int[]>());
                }

                if (!dragonArmy[type].ContainsKey(name))
                {
                    dragonArmy[type].Add(name, new int[3]);
                }

                dragonArmy[type][name][0] = damage;
                dragonArmy[type][name][1] = health;
                dragonArmy[type][name][2] = armor;

            }

            foreach (var dragonType in dragonArmy)
            {
                double averageDmg = 0;
                double averageHealth = 0;
                double averageArmor = 0;

                int counter = 0;
                foreach (var stats in dragonType.Value)
                {
                    averageDmg += stats.Value[0];
                    averageHealth += stats.Value[1];
                    averageArmor += stats.Value[2];
                    counter++;
                }

                Console.WriteLine($"{dragonType.Key}::({averageDmg / counter:F2}/{averageHealth / counter:F2}/{averageArmor / counter:F2})");

                foreach (var dragon in dragonType.Value.OrderBy(d => d.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}