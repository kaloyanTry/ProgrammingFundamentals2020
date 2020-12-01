using System;
using System.Text;

namespace PasswordReset
{
    class PasswordReseter
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();
           
            while (command != "Done")
            {
                if (command.Contains("TakeOdd"))
                {
                    StringBuilder oddChars = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        oddChars.Append(password[i]);
                    }

                    password = oddChars.ToString();
                    Console.WriteLine(password);
                }
                else if (command.Contains("Cut"))
                {
                    string[] splitted = command.Split();
                    int index = int.Parse(splitted[1]);
                    int length = int.Parse(splitted[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (command.Contains("Substitute"))
                {
                    string[] splitted = command.Split();
                    string oldString = splitted[1];
                    string newString = splitted[2];

                    if (password.IndexOf(oldString) >= 0)
                    {
                        password = password.Replace(oldString, newString);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
