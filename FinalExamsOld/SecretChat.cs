using System;

namespace SectretChat
{
    class SecretChat
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] inputCommands = input.Split(":|:");
                string command = inputCommands[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(inputCommands[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string reverseSubstring = inputCommands[1];
                    if (message.Contains(reverseSubstring))
                    {
                        int index = message.IndexOf(reverseSubstring);
                        message = message.Remove(index, reverseSubstring.Length);

                        string subStringToAdd = string.Empty;
                        for (int i = reverseSubstring.Length - 1; i >= 0; i--)
                        {
                            subStringToAdd += reverseSubstring[i];
                        }
                        message = message + subStringToAdd;

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string oldSubstring = inputCommands[1];
                    string newSubstring = inputCommands[2];

                    message = message.Replace(oldSubstring, newSubstring);

                    Console.WriteLine(message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}