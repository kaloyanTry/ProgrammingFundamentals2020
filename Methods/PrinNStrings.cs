using System;
using System.Text;

namespace AddStringd
{
    class PrinNStrings
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = PrintText(text, n);
            Console.WriteLine(result);


        }

        private static string PrintText(string text, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
