using System;
using System.Collections.Generic;
using System.Linq;
namespace HeroesCOde2
{
    class HeroesCOde2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMP = new Dictionary<string, int>();

            int hpMax = 200;
            int mpMax = 100;

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                string heroName = inputData[0];
                int hp = int.Parse(inputData[1]);
                int mp = int.Parse(inputData[2]);

                heroHP[heroName] = hp > hpMax ? hpMax : hp;
            }


            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command.Contains("CastSpell"))
                {
                    string[] inputData = command.Split(" - ");
                    string name = inputData[1];
                    int neededMP = int.Parse(inputData[2]);
                    string spellName = inputData[3];

                    if (heroMP[name] - neededMP >= 0)
                    {

                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroMP[name]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }

                if (command.Contains("TakeDamage"))
                {
                    string[] inputData = command.Split(" - ");
                    string name = inputData[1];
                    int damage = int.Parse(inputData[2]);
                    string attacker = inputData[3];

                    if (heroHP[name] > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroHP[name]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                    }
                }

                if (command.Contains("Recharge"))
                {
                    string[] inputData = command.Split(" - ");
                    string name = inputData[1];
                    int amount = int.Parse(inputData[2]);

                    Console.WriteLine($"{name} recharged for {amount} MP!");
                }

                if (command.Contains("Heal"))
                {
                    string[] inputData = command.Split(" - ");
                    string name = inputData[1];
                    int amount = int.Parse(inputData[2]);

                    Console.WriteLine($"{name} healed for {amount} HP!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
