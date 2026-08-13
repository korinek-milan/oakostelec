using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickeTridy
{
    static internal class Kalkulacka
    {

        public static double ulozeneCislo { get; private set; }
        //nedává smysl mít konstruktor, když nebudu mít instance
        //public Kalkulacka()
        //{

        //}

        public static double scitani(double x, double y)
        {
            double vysledek = x + y;
            ulozeneCislo = vysledek;
            return vysledek;
        }
    }
}
