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
            diapason = "TT-88, T7o-T4o, A9s+, KTo+";
            diapason = diapason.Replace(" ", "");
            string[] cell = diapason.Split(',');
            return cell;
        }
        
        List<string> c = new List<string>();
        public List<Heands> diapasonLight;

        public Convert()
        {
            diapasonLight = new List<Heands>();

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
                    if (b == d)
                    {
                        for (int j = StringToInt(b); j <= 14; j++)
                        {
                            diapasonLight.Add(new Heands(j, j));
                        }
                        
                    }
                    if (a.Contains("o") | a.Contains("s"))
                        {
                            if (a.Contains("o") == true)
                            {
                                string suit = "o";
                                for (int j = StringToInt(d); j < StringToInt(b); j++)
                                {
                                    diapasonLight.Add(new Heands(StringToInt(b), j, suit));
                                }
                            }
                            else
                            {
                                string suit = "s";
                                for (int j = StringToInt(d); j < StringToInt(b); j++)
                                {
                                    diapasonLight.Add(new Heands(StringToInt(b), j, suit));
                                }
                            }
                        }
                    }
                
                if (a.Contains("-"))
                {
                    if (b == d)
                    {
                        char e1 = a[4];
                        string e = e1.ToString();
                        for (int j = StringToInt(e); j <= StringToInt(b); j++)
                        {
                            diapasonLight.Add(new Heands(j, j));
                        }
                    }
                    if (a.Contains("o") | a.Contains("s"))
                    {
                        char f1 = a[5];
                        string f = f1.ToString();
                        if (a.Contains("o") == true)
                        {
                            string suit = "o";
                            for (int j = StringToInt(f); j <= StringToInt(d); j++)
                            {
                                diapasonLight.Add(new Heands(StringToInt(b), j, suit));
                            }
                        }
                        else
                        {
                            string suit = "s";
                            for (int j = StringToInt(f); j <= StringToInt(d); j++)
                            {
                                diapasonLight.Add(new Heands(StringToInt(b), j, suit));
                            }
                        }
                    }
                }
                
            }
            

            Console.WriteLine(diapasonLight[5]);
            Console.ReadLine();

        }
        
    }
}
