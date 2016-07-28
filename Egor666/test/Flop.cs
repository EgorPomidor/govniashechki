using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    public class Flop
    {
        public Card card1 { set; get; }
        public Card card2 { set; get; }
        public Card card3 { set; get; }
        public Flop(Card c1, Card c2, Card c3)
        {
            c1 = card1;
            c2 = card2;
            c3 = card3;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", card1, card2, card3);
        }
    }
}
