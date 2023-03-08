using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Test
    {
        public void Run(int numPlayers)
        {
            Pack pack = new Pack();
            pack.Shuffle();

            List<List<Card>> hands = new List<List<Card>>();
            for (int i = 0; i < numPlayers; i++)
            {
                hands.Add(new List<Card>());
            }

            int playerIndex = 0;
            while (pack.HasCards())
            {
                Card card = pack.Deal();
                hands[playerIndex].Add(card);

                playerIndex++;
                if (playerIndex >= numPlayers)
                {
                    playerIndex = 0;
                }
            }

            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine($"Player {i + 1}:");

                foreach (Card card in hands[i])
                {
                    Console.WriteLine(card.ToString());
                }

                Console.WriteLine();
            }
        }
    }
}
