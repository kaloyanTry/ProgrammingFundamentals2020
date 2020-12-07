using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesCOde2
{
    class HeroesCodeClass
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            int hpMax = 100;
            int mpMax = 200;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                Hero hero = new Hero
                {
                    Name = name,
                    HP = hp > hpMax ? hpMax : hp,
                    MP = mp > mpMax ? mpMax : mp
                };

                heroes.Add(hero);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArg = command.Split(" - ");
                string cmd = cmdArg[0];
                string name = cmdArg[1];

                Hero hero = heroes.FirstOrDefault(h => h.Name == name);

                if (cmd == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];
                    if (hero.MP >= mpNeeded)
                    {
                        hero.MP -= mpNeeded;
                        Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmd == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];
                    if (hero.HP > damage)
                    {
                        hero.HP -= damage;
                        Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                        heroes.Remove(hero);
                    }
                }
                else if (cmd == "Recharge")
                {
                    int amount = int.Parse(cmdArg[2]);

                    if (hero.MP + amount > mpMax)
                    {
                        amount = mpMax - hero.MP;
                        hero.MP = mpMax;
                    }
                    else
                    {
                        hero.MP += amount;
                    }

                    Console.WriteLine($"{hero.Name} recharged for {amount} MP!");
                }
                else if (cmd == "Heal")
                {
                    int amount = int.Parse(cmdArg[2]);

                    if (hero.HP + amount > hpMax)
                    {
                        amount = hpMax - hero.HP;
                        hero.HP = hpMax;
                    }
                    else
                    {
                        hero.HP += amount;
                    }

                    Console.WriteLine($"{hero.Name} healed for {amount} HP!");
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes.OrderByDescending(h => h.HP).ThenBy(n => n.Name))
            {
                Console.WriteLine(hero);
            }
        }
    }

    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Name);
            sb.AppendLine($"  HP: {HP}");
            sb.AppendLine($"  MP: {MP}");

            return sb.ToString().TrimEnd();
        }
    }
}
