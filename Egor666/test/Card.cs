using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    public class Card
    {
        #region Properties
            
        public Suit Suit { get; private set; }
        public int Value { get; private set; }
        #endregion
        
        public Card(int value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }
        
        public override string ToString()
        {
            string suitString = "";

            if (Suit == Suit.h)
                suitString = "h";
            if (Suit == Suit.s)
                suitString = "s";
            if (Suit == Suit.d)
                suitString = "d";
            if (Suit == Suit.c)
                suitString = "c";

            string valueString = Value.ToString();

            if (Value == 10)
                valueString = "T";
            if (Value == 11)
                valueString = "J";
            if (Value == 12)
                valueString = "Q";
            if (Value == 13)
                valueString = "K";
            if (Value == 14)
                valueString = "A";


            return string.Format("{0}{1}", valueString, suitString);
        }
    }
}
