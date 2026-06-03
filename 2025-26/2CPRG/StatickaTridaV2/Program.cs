using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickaTridaV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 42;
            double b = 8;

            //tohle nemůžu udělat, protože statická třída nemá instance
            //Kalkulacka k = new Kalkulacka()
            //k.secti();

            //musím se dotázat přímo celé třídy
            Console.WriteLine(Kalkulacka.secti(a, b));

            Console.WriteLine(Kalkulacka.pi);

            Uzivatel u1 = new Uzivatel("Karel");
            Uzivatel u2 = new Uzivatel("Jirka");
            Console.WriteLine(u1.Jmeno);
            Console.WriteLine(u1.vratJmeno());

            Console.WriteLine(Uzivatel.vratPocetUzivatelu());
            //Třída uživatel se nemůže ptát na instanční atributy
            //Console.WriteLine(Uzivatel.Jmeno);
        }
    }
}
