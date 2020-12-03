using System;

namespace ActivationKeys
{
    class ActivationKeys
    {
        static void Main(string[] args)
        {
            string actKey = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Contains":
                        if (actKey.IndexOf(tokens[1]) != -1)
                        {
                            Console.WriteLine($"{actKey} contains {tokens[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        string firstPart = actKey.Substring(0, startIndex);
                        string secondPart = actKey.Substring(startIndex, endIndex - startIndex);
                        string thirdPart = actKey.Substring(endIndex);
                        if (tokens[1].ToUpper() == "UPPER")
                        {
                            secondPart = secondPart.ToUpper();
                        }
                        else
                        {
                            secondPart = secondPart.ToLower();
                        }
                        actKey = firstPart + secondPart + thirdPart;
                        Console.WriteLine(actKey);
                        break;

                    case "Slice":
                        startIndex = int.Parse(tokens[1]);
                        endIndex = int.Parse(tokens[2]);


                        actKey = actKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(actKey);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {actKey}");
        }
    }
}