using System;

namespace AsciiSumator
{
    class AsciiSumator
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string inputSting = Console.ReadLine();
            int sum = 0;
            foreach (char ch in inputSting)
            {
                if (ch > Math.Min(firstChar, secondChar) && ch < Math.Max(secondChar, firstChar))
                {
                    sum += ch;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
