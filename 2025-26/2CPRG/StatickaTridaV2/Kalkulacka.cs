using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickaTridaV2
{
    static internal class Kalkulacka
    {

        public static double pi { get; private set; } = 3.14159265358979323846;
        public static double ulozeneCislo;

        //Konstruktor není, protože nevznikají instance
        /*public Kalkulacka()
        {
            
        }*/

        static public double secti(double x, double y)
        {
            ulozeneCislo = x + y;
            return ulozeneCislo;
        }
    }
}
