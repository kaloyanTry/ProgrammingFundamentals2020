using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem03
{
    class Problem03
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            int capacityMessages = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] commands = input.Split("=");
                string command = commands[0];
        
                if (input.Contains("Add"))
                {
                    string userName = commands[1];
                    int sentAdd = int.Parse(commands[2]);
                    int receivedAdd = int.Parse(commands[3]);

                    if (!users.ContainsKey(userName))
                    {
                        User user = new User() { Sent = sentAdd, Received = receivedAdd };
                        users.Add(userName, user);
                    }
                }
                else if (input.Contains("Message"))
                {
                    string senderMsg = commands[1];
                    string receiverMsg = commands[2];

                    if (users.ContainsKey(senderMsg) && users.ContainsKey(receiverMsg))
                    {
                        users[senderMsg].Sent += 1;
                        users[receiverMsg].Received += 1;

                        if (users[senderMsg].Sent +users[senderMsg].Received == capacityMessages)
                        {
                            users.Remove(senderMsg);
                            Console.WriteLine($"{senderMsg} reached the capacity!");                       
                        }
                        if (users[receiverMsg].Received + users[receiverMsg].Sent == capacityMessages)
                        {
                            users.Remove(receiverMsg);
                            Console.WriteLine($"{receiverMsg} reached the capacity!");         
                        }
                    }
                }
                else if (input.Contains("Empty"))
                {
                    string userEmpty = commands[1];

                    if (users.ContainsKey(userEmpty))
                    {
                        users.Remove(userEmpty);
                    }

                    if (userEmpty == "All")
                    {
                        users.Clear();
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var user in users.OrderByDescending(u => u.Value.Received).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sent + user.Value.Received}");
            }
        }
    }


    class User
    {
        public int Sent { get; set; }
        public int Received { get; set; }

    }
}
