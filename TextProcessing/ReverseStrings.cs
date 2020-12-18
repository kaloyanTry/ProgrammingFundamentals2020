using System;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string reversedText = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversedText += text[i];
                }

                Console.WriteLine($"{text} = {reversedText}");

                text = Console.ReadLine();
            }
        }
    }
}
