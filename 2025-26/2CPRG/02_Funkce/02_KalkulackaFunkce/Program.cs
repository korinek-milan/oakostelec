using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaFunkce
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 4;
            //int vysledek = soucet(a, b);
            Console.WriteLine(soucet(a, b));

            double c = 4.5;
            double d = 10;

            double vysledek = 10 * (soucet(a, b) + d);

            Console.WriteLine(soucet(c,d));
        }

        static int soucet(int x, int y)
        {
            return x + y;
        }

        static double soucet(double x, double y)
        {
            double vysledek = x + y;
            return vysledek;

            //nikdy se nevykoná, první return ukončí funkci
            vysledek = 42;

            return x + y;
        }
    }
}
