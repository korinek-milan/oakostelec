using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zkouseni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kniha k1 = new Kniha("nazev 1");
            Kniha k2 = new Kniha("nazev 2");

            Console.WriteLine(k1.Nazev);
            k1.Nazev = "nove jmeno";
            Console.WriteLine(k1.Nazev);
            k1.Nazev = "nový název";

            Regal r = new Regal();
            r.pridejKnihu(k1);
            r.pridejKnihu(k2);

            r.VypisNazvy();
            Console.WriteLine(r.VratNazvyVeStringu());

            foreach (Kniha item in r.vratSeznam())
            {
                Console.WriteLine(item.VratNazev());
            }
        }
    }
}
