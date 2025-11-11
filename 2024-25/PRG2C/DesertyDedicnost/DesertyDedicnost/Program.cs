using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesertyDedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dort d = new Dort("Čízký dort", 1000, false, 1);
            Dort d2 = new Dort("Ledový", 500, true, 4);
            Console.WriteLine(d.VratInfo());

            d.PridejPatro(7);

            List<Dezert> dezerts = new List<Dezert>();
            dezerts.Add(d);
            dezerts.Add(d2);

            foreach (Dezert dezert in dezerts)
            {
                Console.WriteLine(dezert.VratInfo());
            }
        }
    }
}
