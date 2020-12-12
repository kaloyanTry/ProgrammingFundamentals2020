using System;
using System.Collections.Generic;

namespace ValidUsernames
{
    class ValidNames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            List<string> validUsers = new List<string>();

            foreach (var name in input)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    bool isValid = true;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!(char.IsLetterOrDigit(name[i]) || name.Contains('-') || name.Contains('_')))
                        {
                            isValid = false;  
                        }
                    }
                    if (isValid)
                    {
                        validUsers.Add(name);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsers));
        }
    }
}
