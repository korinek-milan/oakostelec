using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt p1 = new Produkt("Jablko", 10);
            Produkt p4 = new Produkt("Jablko", 10);
            Produkt p2 = new Produkt("Hruška", 15.5);
            Produkt p3 = new Produkt("Švestka", 45.9);

            Kosik k = new Kosik();

            k.PridejPolozku(p1, 10);
            k.PridejPolozku(p3, 5);

            Console.WriteLine(k.celkovaCena());

            k.OdeberPolozku(p1);

            Console.WriteLine(k.celkovaCena());
            //Console.WriteLine(k.celkovaCena());

            Console.WriteLine(k.VypisVsechnyPridaneProdukty());
        }
    }
}
