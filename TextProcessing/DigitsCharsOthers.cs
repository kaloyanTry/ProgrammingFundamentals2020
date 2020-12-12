using System;
using System.Text;

namespace StringOfDigitsLettersOther
{
    class DigitsCharsOthers
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder chars = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    chars.Append(text[i]);
                }
                else
                {
                    others.Append(text[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(others);
        }
    }
}
