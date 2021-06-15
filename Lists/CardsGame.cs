using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> cardsFirstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> cardsSecondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (cardsFirstPlayer.Count != 0 && cardsSecondPlayer.Count != 0)
            {
                int firstPlayerCard = cardsFirstPlayer[0];
                int secondPlayerCard = cardsSecondPlayer[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    cardsFirstPlayer.Add(firstPlayerCard);
                    cardsFirstPlayer.Add(secondPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    cardsSecondPlayer.Add(secondPlayerCard);
                    cardsSecondPlayer.Add(firstPlayerCard);
                }
                
                cardsFirstPlayer.RemoveAt(0);
                cardsSecondPlayer.RemoveAt(0);
            }

            if (cardsFirstPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {cardsSecondPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {cardsFirstPlayer.Sum()}");
            }
        }
    }
}
