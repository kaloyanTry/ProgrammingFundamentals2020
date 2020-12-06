using System;
using System.Collections.Generic;
using System.Linq;

namespace Pianist
{
    class ThePianist
    {
        static void Main(string[] args)
        {
            Dictionary<string, Pianist> pianists = new Dictionary<string, Pianist>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputPianists = input.Split('|');
                string pieceName = inputPianists[0];
                string composer = inputPianists[1];
                string key = inputPianists[2];

                Pianist pianist = new Pianist(composer, key);
                pianists.Add(pieceName, pianist);

            }

            string inputCommands = Console.ReadLine();
            while (inputCommands != "Stop")
            {
                string[] commands = inputCommands.Split('|');
                string command = commands[0];
                
                if (command == "Add")
                {
                    string pieceName = commands[1];
                    string composerName = commands[2];
                    string pieceKey = commands[3];
                    if (pianists.ContainsKey(pieceName))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        Pianist pianist = new Pianist(composerName, pieceKey);
                        pianists.Add(pieceName, pianist);
                        Console.WriteLine($"{pieceName} by {composerName} in {pieceKey} added to the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    string pieceName = commands[1];
                    if (pianists.ContainsKey(pieceName))
                    {
                        pianists.Remove(pieceName);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string pieceName = commands[1];
                    string pieceKey = commands[2];

                    if (pianists.ContainsKey(pieceName))
                    {
                        pianists[pieceName].KeyPiece = pieceKey;
                        Console.WriteLine($"Changed the key of {pieceName} to {pieceKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }

                inputCommands = Console.ReadLine();
            }

            foreach (var pianist in pianists.OrderBy(p => p.Key).ThenBy(p => p.Value.NameComposer))
            {
                Console.WriteLine($"{pianist.Key} -> Composer: {pianist.Value.NameComposer}, Key: {pianist.Value.KeyPiece}");
            }
        }
    }
    class Pianist
    {
        public string NameComposer { get; set; }
        public string KeyPiece { get; set; }

        public Pianist(string nameComposer, string keyPiece)
        {
            NameComposer = nameComposer;
            KeyPiece = keyPiece;
        }
    }
}
