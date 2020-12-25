using System;

namespace Problem01
{
    class Problem01
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Sign up")
            {
                string[] commands = input.Split();
                
                if (input.Contains("Case"))
                {
                    string cases = commands[1];
                    if (cases == "lower")
                    {
                        userName = userName.ToLower();
                    }
                    else if (cases == "upper")
                    {
                        userName = userName.ToUpper();
                    }
                    Console.WriteLine(userName);
                }
                else if (input.Contains("Reverse"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex >= 0 && startIndex < userName.Length && endIndex > 0 && endIndex <= userName.Length - 1)
                    {
                        string subString = userName.Substring(startIndex, endIndex + 1 - startIndex);
                        string newString = string.Empty;
                        
                        for (int i = subString.Length - 1; i >= 0; i--)
                        {
                            newString += subString[i];
                        }

                        Console.WriteLine(newString);
                    }
                }
                else if (input.Contains("Cut"))
                {
                    string subText = commands[1];
                    int indexSubText = userName.IndexOf(subText);
                    
                    if (userName.Contains(subText))
                    {
                        userName = userName.Remove(indexSubText, subText.Length);

                        Console.WriteLine(userName);
                    }
                    else
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {subText}.");
                    }
                }
                else if (input.Contains("Replace"))
                {
                    string charReplace = commands[1];
                    userName = userName.Replace(charReplace, "*");

                    Console.WriteLine(userName);
                }
                else if (input.Contains("Check"))
                {
                    string charValid = commands[1];

                    if (userName.Contains(charValid))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {charValid}.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
