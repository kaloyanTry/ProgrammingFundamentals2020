using System;

namespace Reverse3Chars
{
    class ReverseChars
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdChar} {secondChar} {firstChar}");
        }
    }
}
