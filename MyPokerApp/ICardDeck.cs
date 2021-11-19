using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPokerApp
{
    public interface ICardDeck
    {
        public ICard[] Cards { get; set; }

        public void Shuffle();
    }
}
