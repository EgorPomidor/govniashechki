using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor666
{
    class Convert
    {
        
        public string[] diapason()
        {
            string diapason;
            diapason = "77+, A9s+, KTs+";
            diapason = diapason.Replace(" ", "");
            string[] cell = diapason.Split(',');
            return cell;
        }
        
        List<string> c = new List<string>();
        List<ConvertPlus> convertPluse;

        public Convert()
        {
            convertPluse = new List<ConvertPlus>();

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
                        #region
                        if (b == "2")
                        {
                            c.RemoveAt(i);
                            c.Add("22");
                            c.Add("33");
                            c.Add("44");
                            c.Add("55");
                            c.Add("66");
                            c.Add("77");
                            c.Add("88");
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "3")
                        {
                            c.RemoveAt(i);
                            c.Add("33");
                            c.Add("44");
                            c.Add("55");
                            c.Add("66");
                            c.Add("77");
                            c.Add("88");
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "4")
                        {
                            c.RemoveAt(i);
                            c.Add("44");
                            c.Add("55");
                            c.Add("66");
                            c.Add("77");
                            c.Add("88");
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "5")
                        {
                            c.RemoveAt(i);
                            c.Add("55");
                            c.Add("66");
                            c.Add("77");
                            c.Add("88");
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "6")
                        {
                            c.RemoveAt(i);
                            c.Add("66");
                            c.Add("77");
                            c.Add("88");
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "7")
                        {
                            c.RemoveAt(i);
                            c.Add("77");
                            c.Add("88");
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "8")
                        {
                            c.RemoveAt(i);
                            c.Add("22");
                            c.Add("33");
                            c.Add("44");
                            c.Add("55");
                            c.Add("55");
                            c.Add("77");
                            c.Add("88");
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                        }
                        if (b == "9")
                        {
                            c.RemoveAt(i);
                            c.Add("99");
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "T")
                        {
                            c.RemoveAt(i);
                            c.Add("TT");
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "J")
                        {
                            c.RemoveAt(i);
                            c.Add("JJ");
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "Q")
                        {
                            c.RemoveAt(i);
                            c.Add("QQ");
                            c.Add("KK");
                            c.Add("AA");
                        }
                        if (b == "K")
                        {
                            c.RemoveAt(i);
                            c.Add("KK");
                            c.Add("AA");
                        }
                        #endregion
                    }
                    if (a.Contains("o") | a.Contains("s"))
                    {
                        int v1 = 0;
                        int v2 = 0;
                        Suit1 suit;
                        #region
                        if (b == "2") { v1 = 2; }
                        if (b == "3") { v1 = 3; }
                        if (b == "4") { v1 = 4; }
                        if (b == "5") { v1 = 5; }
                        if (b == "6") { v1 = 6; }
                        if (b == "7") { v1 = 7; }
                        if (b == "8") { v1 = 8; }
                        if (b == "9") { v1 = 9; }
                        if (b == "T") { v1 = 10; }
                        if (b == "J") { v1 = 11; }
                        if (b == "Q") { v1 = 12; }
                        if (b == "K") { v1 = 13; }
                        if (b == "A") { v1 = 14; }

                        if (d == "2") { v2 = 2; }
                        if (d == "3") { v2 = 3; }
                        if (d == "4") { v2 = 4; }
                        if (d == "5") { v2 = 5; }
                        if (d == "6") { v2 = 6; }
                        if (d == "7") { v2 = 7; }
                        if (d == "8") { v2 = 8; }
                        if (d == "9") { v2 = 9; }
                        if (d == "T") { v2 = 10; }
                        if (d == "J") { v2 = 11; }
                        if (d == "Q") { v2 = 12; }
                        if (d == "K") { v2 = 13; }
                        if (d == "A") { v2 = 14; }
                        #endregion
                        if (a.Contains("o") == true)
                        {
                            suit = Suit1.o;
                        }
                        else
                        {
                            suit = Suit1.s;
                        }
                        convertPluse.Add(new ConvertPlus(v1, v2, suit));
                    }

                }



            }

            Console.WriteLine(c[5]);
            Console.ReadLine();
        }
       
    }
}
