using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPokerApp
{
    public class CardDeck : ICardDeck
    {
        public ICard[] Cards { get; set; }

        public CardDeck()
        {
            Cards = new Card[52];
            int i = 0;
            foreach (CardSuit suit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                foreach(CardValue value in (CardValue[])Enum.GetValues(typeof(CardValue)))
                {
                    Cards[i] = new Card(value, suit);
                    i++;
                }
            }
        }

        public void Shuffle()
        {
            
        }
    }
}
