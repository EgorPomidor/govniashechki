using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    /*
     * Это описание нового класса с именем Card.
     * public значит что он виден из других программ.
     * 
     * У него есть два свойства (Suit и Value).
     */
    /// <summary>
    /// Карта.
    /// </summary>
    public class Card
    {
        //Это регион с именем Properties, он чисто для удобства (можно сворачивать/разворачивать). 
        #region Properties

        //Это свойство с именем Suit (его можно читать (get), но нельзя изменять (private set))
        public Suit Suit { get; private set; }

        public int Value { get; private set; }

        #endregion

        /* Это конструктор объекта Card (метод, имя которого совпадает с именем класса)
         * В него передаются два параметра (масть и значение).
         */
        public Card(Suit suit, int value)
        {
            //Здесь копируются переданные значения во внутренние свойства, теперь их нельзя изменить снаружи.
            Suit = suit;
            Value = value;
        }

        /* Это переопределение (override) метода ToString
         * Любой класс неявно наследуется от класса object, у которого есть метод ToString
         * Здесь мы заменяем стандартную реализацию метода ToString своим кодом
         */
        public override string ToString()
        {
            //Тут мы преобразуем класс в удобный для восприятия текст:

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
