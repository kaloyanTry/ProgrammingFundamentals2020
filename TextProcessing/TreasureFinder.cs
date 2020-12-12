using System;
using System.Linq;
using System.Text;

namespace TreasureFinder
{
    class TreasureFinder
    {
        static void Main(string[] args)
        {
            int[] keyNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;

            string input = Console.ReadLine();

            while (input != "find")
            {
                StringBuilder message = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    message.Append(Convert.ToChar(input[i] - keyNumbers[i % keyNumbers.Length]));
                }

                string messageAsString = message.ToString();

                int startIndTreasure = messageAsString.IndexOf('&') + 1;
                int lengthTreasure = messageAsString.LastIndexOf('&') - startIndTreasure;
                string treasure = messageAsString.Substring(startIndTreasure, lengthTreasure);

                int startIndCoordinates = messageAsString.IndexOf('<') + 1;
                int lengthCoordinates = messageAsString.LastIndexOf('>') - startIndCoordinates;
                string coordinates = messageAsString.Substring(startIndCoordinates, lengthCoordinates);

                Console.WriteLine($"Found {treasure} at {coordinates}");

                input = Console.ReadLine();
            }
        }
    }
}
