using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Flop flop = new Flop(deck.Cards[0], deck.Cards[1], deck.Cards[2]);

            deck.Cards.RemoveAt(0);
            deck.Cards.RemoveAt(0);
            deck.Cards.RemoveAt(0);

            Console.WriteLine(flop);


            //for (int i= 0; i<5;i++)
            //{
            //    Console.Write(cards[i]);
            //}

            //Ждем пока пользователь нажмет любую клавишу.
            Console.ReadKey();
        }


    }
}
