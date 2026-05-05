using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektyInstanceTridy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new Uzivatel();
            //Uzivatel uzivatel = new Uzivatel();

            int vek = 20;
            Uzivatel u1 = new Uzivatel("Karel", vek, "Kostelec", "123 45", "Nová", "42");
            
            Adresa a = new Adresa("Komenského", "12", "Rychnov", "516 01");
            //mohu použít proměnnou jména "a" a nebo přímo vytvořit novou instanci při volání konstruktoru
            //Uzivatel u2 = new Uzivatel("Karel", 40, a);
            Uzivatel u2 = new Uzivatel("Karel", 40, new Adresa("Komenského", "12", "Rychnov", "516 01"));

            Uzivatel prazdny = new Uzivatel();
            List<string> l = new List<string>();


            Adresa zatimPrazdna = prazdny.vratAdresu();
            //zatimPrazdna = null;
            if(zatimPrazdna != null)
            {
                Console.WriteLine(zatimPrazdna.Mesto);
            }

            //staticka trida - jediná třída, kde nevytvářím instanci, protože chování by se stejně
            //nezměnilo. Chování se mění pouze na základě vstupů do té funkce
            //Jediná třída, kde "dovnitř" vstupuji přes název třídy, ne přes proměnnou
            Console.WriteLine(Kalkulator.soucet(10, 15));
        }
    }
}
