using System;

namespace DecryptingMessages
{
    class Decripting
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char inputCase = char.Parse(Console.ReadLine());

                inputCase += (char)(key);

                message += inputCase;
            }

            Console.WriteLine(message);
        }
    }
}
