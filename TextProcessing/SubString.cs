using System;

namespace SubString
{
    class SubString
    {
        static void Main(string[] args)
        {
            string removeString = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int index = text.IndexOf(removeString);
            while (index != -1)
            {
                text = text.Remove(index, removeString.Length);
                index = text.IndexOf(removeString);
            }

            Console.WriteLine(text);
        }
    }
}
