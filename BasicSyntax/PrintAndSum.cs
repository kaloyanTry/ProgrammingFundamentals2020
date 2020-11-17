using System;

namespace PrintSum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = num1; i <= num2; i++)
            {
                Console.Write($"{i} ");
                result += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {result}");
        }
    }
}
