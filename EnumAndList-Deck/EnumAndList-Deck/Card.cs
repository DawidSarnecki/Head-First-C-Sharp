using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAndList_Deck
{
    class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
        public string Name { get
            { return Value + " of " + Suit; } }

        public Card (Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

    }
}
