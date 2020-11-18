using System;

namespace LowerOrUpper
{
    class LowerUpperChar
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

            bool isUpper = true;
            isUpper = Char.IsUpper(firstChar);

            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
