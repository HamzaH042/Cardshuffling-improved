using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        private List<Card> cards = new List<Card>();

        // Get the number of cards left in the deck
        public int RemainingCards { get { return cards.Count; } }

        // Constructor initializes a new Pack object with 52 cards of all possible combinations of suits and values
        public Pack()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        // Shuffle the deck using the Fisher-Yates algorithm
        public void Shuffle()
        {
            Random random = new Random();

            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        // Remove and return the top card from the deck
        public Card Deal()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("There are no more cards left in the pack.");
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        // Check if there are any cards left in the deck
        public bool HasCards()
        {
            return cards.Count > 0;
        }
    }
}