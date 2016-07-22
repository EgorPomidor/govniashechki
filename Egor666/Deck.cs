using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    /// <summary>
    /// 
    /// Колода карт.
    /// </summary>
    public class Deck
    {
        /*
         * Это поле класса.
         * Оно объявлено как private, это значит что оно видно только внутри этого класса.
         */
        private List<Card> _deck;

      

        public List<Card> Cards
        {
            get { return  new List<Card>(_deck); }
        }
        /*
       * Это конструктор класса (метод, имя которого совпадает с именем класса).
       * Он автоматически выполняется при создании объекта типа Deck.
       */
        public Deck()
        {
            //Сгенерим новую колоду:
            
            _deck = new List<Card>();

            for (int i = 2; i < 15; i++)
            {
                _deck.Add(new Card(Suit.h, i));
                _deck.Add(new Card(Suit.d, i));
                _deck.Add(new Card(Suit.c, i));
                _deck.Add(new Card(Suit.s, i));
            }

            Random rnd = new Random();

            List<Card> newArr = new List<Card>();

            while (_deck.Count > 0)
            {
                int index = rnd.Next(0, _deck.Count);

                var card = _deck[index];

                _deck.Remove(card);

                newArr.Add(card);
            }

            _deck = newArr;
        }
        public Card[] flop()
        {
            Card[] flop = new Card[3];
            for (int i=0; i<2; i++)
            {
                flop[i] = _deck[i];
                _deck.RemoveAt(i);
            }
            return flop;
        }

    }
}
