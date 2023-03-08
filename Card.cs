using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        // Constructor to create a new card with a given suit and value
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        // Method to override the ToString() method to print the card's value and suit
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

}
   

