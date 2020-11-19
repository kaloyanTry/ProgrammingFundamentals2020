using System;
using System.Linq;

namespace ReverseStringArray
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split(' ').ToArray();
            string[] reversedArray = new string[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                reversedArray[i] = stringArray[stringArray.Length - i - 1];
            }

            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
        }
    }
}