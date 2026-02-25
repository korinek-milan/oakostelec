using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridaAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            Ridic r1 = new Ridic();

            a1.znacka = "Peugeot";
            a1.rokVyroby = 2005;

            r1.Jmeno = "Karel";
            r1.Vek = 42;
            r1.vlastnenaVozidla.Add(a1);
            //r1.vlastneneVozidlo = a1;
            //Console.WriteLine(r1.vlastneneVozidlo.znacka);

            Ridic r2 = new Ridic();
            r2.Jmeno = "Jana";
            r2.Vek = 35;
            //r2.vlastneneVozidlo = a1;
            //Console.WriteLine(r2.vlastneneVozidlo.znacka);

            //a1.znacka = "BMW";
            //Console.WriteLine(r2.vlastneneVozidlo.znacka);

            Auto a2 = new Auto();
            a2.znacka = "Porsche";
            a2.rokVyroby = 2025;

            r1.vlastnenaVozidla.Add(a2);

            foreach (Auto item in r1.vlastnenaVozidla)
            {
                Console.WriteLine(item.znacka);
            }

        }
    }
}
