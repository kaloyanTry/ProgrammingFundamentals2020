using System;
using System.Collections.Generic;
using System.Globalization;

namespace Messaging
{
    class Messaging
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();
                string command = commands[0];

                switch (command)
                {
                    case "Chat":
                        string msgChat = commands[1];
                        messages.Add(msgChat);
                        break;

                    case "Delete":
                        string msgDelete = commands[1];
                        if (messages.Contains(msgDelete))
                        {
                            messages.Remove(msgDelete);
                        }
                        break;

                    case "Edit":
                        string msgOld = commands[1];
                        string msgEdited = commands[2];
                        int indMsgOld = messages.IndexOf(msgOld);
                        messages[indMsgOld] = msgEdited;
                        break;

                    case "Pin":
                        string msgPin = commands[1];
                        string tempPin = msgPin;
                        messages.Remove(msgPin);
                        messages.Add(tempPin);
                        break;

                    case "Spam":
                        for (int i = 1; i < commands.Length; i++)
                        {
                            messages.Add(commands[i]);
                        }                      
                        break;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, messages));
        }
    }
}
