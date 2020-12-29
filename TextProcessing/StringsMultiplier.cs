using System;

namespace CharMultiplier
{
    class StringsMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        static int CharMultiplier(string firstString, string secondString)
        {
            int sum = 0;

            string longestString = string.Empty;
            string shortestString = string.Empty;

            if (firstString.Length > secondString.Length)
            {
                longestString = firstString;
                shortestString = secondString;
            }
            else
            {
                longestString = secondString;
                shortestString = firstString;
            }

            for (int i = 0; i < shortestString.Length; i++)
            {
                sum += shortestString[i] * longestString[i];
            }

            for (int i = shortestString.Length; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }

            return sum;
        }
    }
}
