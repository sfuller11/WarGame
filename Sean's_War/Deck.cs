using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sean_s_War
{
    class Deck
    {
        private Card[] deck;
        private int currentCard;
        private Random ran;

        public Deck()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] faces = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King","Ace" };
            int[] value = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            deck = new Card[52];
            currentCard = 0;

            for(int i = 0;i < deck.Length; i++)
            {
                deck[i] = new Card(faces[i % 13], suits[i / 13], value[i % 13]);
            }
        }

        public void shuffle()
        {
            ran = new Random();
            currentCard = 0;
            for(int i = 0;i < deck.Length; i++)
            {
                int random = ran.Next(52);
                Card temp = deck[i];
                deck[i] = deck[random];
                deck[random] = temp;
            }
        }

        public Card DrawCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
