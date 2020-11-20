using System;

namespace CharsInRange
{
    class CharsInRange
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            PrintChars(input1, input2);

        }

        private static void PrintChars(char input1, char input2)
        {
            if (input1 < input2)
            {
                for (int i = input1 + 1; i < input2; i++)
                {
                    Console.Write((char)i + " ");
                }

            }
            else
            {
                for (int i = input2 + 1; i < input1; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
