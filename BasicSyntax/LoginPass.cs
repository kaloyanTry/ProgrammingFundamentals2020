using System;

namespace Login
{
    class LoginPass
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string userPass = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                userPass += userName[i];
            }

            int count = 0;
            while (true)
            {
                string currentUser = Console.ReadLine();
                if (currentUser != userPass)
                {
                    count++;

                    if (count == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
            }
        }
    }
}
