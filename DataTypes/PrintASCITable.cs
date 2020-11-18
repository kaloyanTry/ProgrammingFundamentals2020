using System;

namespace PrintACII
{
    class PrintASCITable
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int finishChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= finishChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
