using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorSouctuTest
{
    internal class Kalkulator
    {

        public double SpocitejSoucet(double[] vstup)
        {
            double vysledek = 0;
            foreach (double item in vstup)
            {
                vysledek += item;
            }

            return vysledek;
        }
    }
}
