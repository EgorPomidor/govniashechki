using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    class Heands
    {
        public string Suit { get; private set; }

        public int Value1 { get; private set; }
        public int Value2 { get; private set; }
        public Heands(int value1, int value2, string suit)
        {
            Value1 = value1;
            Value2 = value2;
            Suit = suit;
        }
        public Heands(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public override string ToString()
        {

            string suitString = Suit;

            string valueString = Value1.ToString();

            if (Value1 == 10)
                valueString = "T";
            if (Value1 == 11)
                valueString = "J";
            if (Value1 == 12)
                valueString = "Q";
            if (Value1 == 13)
                valueString = "K";
            if (Value1 == 14)
                valueString = "A";

            string valueString2 = Value2.ToString();

            if (Value2 == 10)
                valueString2 = "T";
            if (Value2 == 11)
                valueString2 = "J";
            if (Value2 == 12)
                valueString2 = "Q";
            if (Value2 == 13)
                valueString2 = "K";
            if (Value2 == 14)
                valueString2 = "A";


            return string.Format("{0}{1}{2}", valueString, valueString2, suitString);
        }
    }
}
