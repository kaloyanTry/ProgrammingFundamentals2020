using System;
using System.Linq;

namespace CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            foreach (var word in secondArray)
            {
                if (firstArray.Contains(word))
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}
