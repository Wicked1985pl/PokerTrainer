using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPokerApp
{
    public class Card : ICard
    {
        public CardValue Value { get; set; }
        public CardSuit Suit { get; set; }

        public Card(){}

        public Card(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}
