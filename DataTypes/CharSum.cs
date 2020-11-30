using System;

namespace SumOfChars
{
    class CharSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char charsLatin = char.Parse(Console.ReadLine());
                sum += charsLatin;
            }
            
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
