using System;

namespace EvenNum
{
    class EvenNumInput
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(num)}");
            }
            else
            {
                do
                {
                    Console.WriteLine("Please write an even number.");
                    num = int.Parse(Console.ReadLine());
                } while (num % 2 != 0);

                Console.WriteLine($"The number is: {Math.Abs(num)}");

            }
        }
    }
}
