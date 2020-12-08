using System;

namespace ExtractPersonInformation
{
    class ExtractInformation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int startIndexOfName = input.IndexOf("@") + 1;
                int lengthOfName = input.IndexOf("|") - startIndexOfName;

                int startIndexOfAge = input.IndexOf("#") + 1;
                int lengthOfAge = input.IndexOf("*") - startIndexOfAge;

                string name = input.Substring(startIndexOfName, lengthOfName);
                int age = int.Parse(input.Substring(startIndexOfAge, lengthOfAge));

                Console.WriteLine($"{name} is {age} years old.");

            }
        }
    }
}
