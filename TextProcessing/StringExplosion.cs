﻿using System;
using System.Text;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());

                }
                else if (power > 0)
                {
                    input = input.Remove(i, 1);
                    power--;
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
