

using System;

namespace MyPokerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CardDeck deck = new CardDeck();
            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{Enum.GetName(typeof(CardValue), card.Value)} of {Enum.GetName(typeof(CardSuit), card.Suit)}");
            }
            deck.Shuffle();
            Console.ReadKey();
        }
    }
}
