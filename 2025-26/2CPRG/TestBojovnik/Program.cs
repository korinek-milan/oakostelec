using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBojovnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bojovnik b1 = new Bojovnik("Karel");
            Bojovnik b2 = new Bojovnik("Jonáš");
            Bojovnik b3 = new Bojovnik("Jirka");
            Bojovnik b4;

            try
            {
                Console.WriteLine("Zadej jméno");
                string jmenoUzivatel = Console.ReadLine();
                b4 = new Bojovnik(jmenoUzivatel);
                Turnaj.PridejBojovnika(b4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Turnaj.PridejBojovnika(b1);
            Turnaj.PridejBojovnika(b2);
            Turnaj.PridejBojovnika(b3);

            Turnaj.SpustSouboj();

            if (Turnaj.JeVitez() == true)
            {
                Console.WriteLine("Vítěz existuje");
            }
            else
            {
                Console.WriteLine("V turnaji je několik účastníků");
            }
        }
    }
}
