using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    // короче, я хочу переконвертировать "77+, A9s+, KTs+" в 77, 88, 99... и так далее . и добавить эти элементы в колеекцию diapasonLight. 
    class Convert : IForConvert
    {
        public int StringToInt(string a)
        {
            if (a == "T") { a = "10"; }
            if (a == "J") { a = "11"; }
            if (a == "Q") { a = "12"; }
            if (a == "K") { a = "13"; }
            if (a == "A") { a = "14"; }
            int b = Int32.Parse(a);
            return b;
        }  
        
        public string[] diapason()
        {
            string diapason;
            diapason = "77+, A9s+, KTs+";
            diapason = diapason.Replace(" ", "");
            string[] cell = diapason.Split(',');
            return cell;
        }
        
        List<string> c = new List<string>();
        List<DiapasonLight> diapasonLight;

        public Convert()
        {
            diapasonLight = new List<DiapasonLight>();

            for (int i = 0; i < diapason().Length; i++)
            {
                c.Add(diapason()[i]);
            }
            for (int i = 0; i < diapason().Length; i++)
            {
                string a = c[i]; 

                char b1 = a[0];
                string b = b1.ToString();

                char d1 = a[1];
                string d = d1.ToString();

                if (a.Contains("+"))
                {

                    // вот тут я добавля пары
                    if (b == d)
                    {
                        for (int j = StringToInt(b); j <= 14; j++)
                        {
                            diapasonLight.Add(new DiapasonLight(j, j));
                        }
                        // тут я не понял, почему добавляются в DiapasonLight(j, j) еще третий аргумент Suit1 = s
                    }
                    // а тут не пары
                    if (a.Contains("o") | a.Contains("s"))
                        {
                            Suit1 suit;
                            if (a.Contains("o") == true)
                            {
                                suit = Suit1.o;
                                for (int j = StringToInt(d); j < StringToInt(b); j++)
                                {
                                    diapasonLight.Add(new DiapasonLight(StringToInt(b), j, suit));
                                }
                            }
                            else
                            {
                                suit = Suit1.s;
                                for (int j = StringToInt(d); j < StringToInt(b); j++)
                                {
                                    diapasonLight.Add(new DiapasonLight(StringToInt(b), j, suit));
                                }
                            }
                        }
                    }

                // тут я еще не доделал (((
                if (a.Contains("-"))
                {

                }


            }
            


            Console.WriteLine(diapasonLight[5]);
            Console.ReadLine();

        }
        
    }
}
