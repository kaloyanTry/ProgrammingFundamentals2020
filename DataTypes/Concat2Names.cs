using System;

namespace ConcatNames
{
    class Concat2Names
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine();
            string nameDelimiter = Console.ReadLine();

            Console.Write($"{nameFirst}{nameDelimiter}{nameSecond}");
        }
    }
}
