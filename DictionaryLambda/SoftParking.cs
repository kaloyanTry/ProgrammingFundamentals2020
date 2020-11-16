using System;
using System.Collections.Generic;

namespace TrainingAssociative
{
    class Training
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                string command = inputData[0];
                string username = inputData[1];

                if (command == "register")
                {
                    string licenseNumber = inputData[2];

                    User user = new User(username, licenseNumber);

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                    }
                    else
                    {
                        users.Add(username, user);
                        Console.WriteLine($"{username} registered {licenseNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value.LicenseNumber}");
            }
        }
    }

    class User
    {
        public string Username { get; set; }
        public string LicenseNumber { get; set; }

        public User(string username, string licenseNumber)
        {
            Username = username;
            LicenseNumber = licenseNumber;
        }
    }
}