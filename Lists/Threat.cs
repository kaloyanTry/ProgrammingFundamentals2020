using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AnonymousThreat
{
    class Threat
    {
        static void Main(string[] args)
        {
            List<string> inputString = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commandElements = input.Split().ToArray();
                string command = commandElements[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandElements[1]);
                    int endIndex = int.Parse(commandElements[2]);

                    string concateString = String.Empty;

                    if (startIndex < 0)
                    {
                        if (endIndex >= 0 && endIndex <= inputString.Count - 1)
                        {
                            startIndex = 0;
                        }
                    }
                    if (endIndex > inputString.Count - 1)
                    {
                        if (startIndex >= 0 && startIndex <= inputString.Count - 1)
                        {
                            endIndex = inputString.Count - 1;
                        }
                    }
                    if ((startIndex >= 0 && startIndex <= inputString.Count - 1) && (endIndex >= 0 && endIndex <= inputString.Count - 1))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concateString += inputString[i];
                        }

                        inputString.RemoveRange(startIndex, (endIndex - startIndex + 1));
                        inputString.Insert(startIndex, concateString);
                    }
                }

                else if (command == "divide")
                {
                    int index = int.Parse(commandElements[1]);
                    int partitions = int.Parse(commandElements[2]);

                    if (index >= 0 && index <= inputString.Count - 1)
                    {
                        string word = inputString[index];
                        List<string> dividedWords = new List<string>();
                        int stringLengthToAdd = word.Length / partitions;
                        int startIndex = 0;

                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == (partitions - 1))
                            {
                                dividedWords.Add(word.Substring(startIndex, word.Length - startIndex));
                            }
                            else
                            {
                                dividedWords.Add(word.Substring(startIndex, stringLengthToAdd));
                                startIndex += stringLengthToAdd;
                            }
                        }

                        inputString.RemoveAt(index);
                        inputString.InsertRange(index, dividedWords);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", inputString));
        }
    }
}
