using System;

namespace MultyTable
{
    class Multyplication
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num} X {times} = {num * times}");
                times++;

            } while (times <= 10);
        }
    }
}
