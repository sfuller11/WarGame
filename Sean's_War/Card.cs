using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sean_s_War
{
    public class Card
    {
        private string face;
        private string suit;
        private int value;

        public Card(string Face, string Suit, int Value)
        {
            face = Face;
            suit = Suit;
            value = Value;
        }

        public override string ToString()
        {
            return face + " of " + suit;
        }

        public int getValue()
        {
            return value;
        }
    }
}
