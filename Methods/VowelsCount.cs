using System;

namespace VowelsCount
{
    class VowelsCount
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = CountVowels(input);
            Console.WriteLine(result);
        }

        static int CountVowels(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool isVowel = input[i] == 'a' || 
                    input[i] == 'e' || input[i] == 'i' || 
                    input[i] == 'o' || input[i] == 'u';

                if (isVowel)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
