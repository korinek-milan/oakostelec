using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dolucovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Balik b1 = new Balik(123, "Karel");
            Balik b2 = new Balik(456, "Jirka");
            Balik b3 = new Balik(789, "Jonáš");
            int cisloBaliku = 0;
            string jmeno = "";
            try
            {
                
                Console.WriteLine("Zadej číslo balíku");
                cisloBaliku = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadej jméno příjemce");
                jmeno = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nastala neočekávaná chyba");
                Console.WriteLine(ex.Message);
            }
            Balik b4 = new Balik(cisloBaliku, jmeno);

            Depo d = new Depo();
            d.pridejBalik(b1);
            d.pridejBalik(b2);
            d.pridejBalik(b3);
            d.pridejBalik(b4);

            Console.WriteLine(d.vypisInfoOVsechBalicich());

            d.dorucJeden();
            d.dorucJeden();

            Console.WriteLine(d.spocitejDorucene() + "\n" + d.spocitejJesteNedorucovane() + "\n" + d.vratNedorucene());

            //Console.WriteLine(b1.VratInfo());


        }
    }
}
