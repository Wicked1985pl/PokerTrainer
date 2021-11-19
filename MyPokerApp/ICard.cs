using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPokerApp
{
    public interface ICard
    {
        public CardValue Value { get; set; }
        public CardSuit Suit { get; set; }
    }
}
