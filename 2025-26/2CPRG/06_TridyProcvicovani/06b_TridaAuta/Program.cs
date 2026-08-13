using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridaAuta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stejně jako obyčejnou int proměnnou
            //int x = 5;
            //vytvářím i objekt datového typu Auto
            Auto a1 = new Auto();

            a1.Nazev = "Audi";
            a1.Rychlost = 200;

            Ridic r1 = new Ridic();
            r1.Jmeno = "Karel";
            r1.Vek = 20;
            //r1.vlastneneAuto = a1;
            r1.vlastnenaAuta.Add(a1);

            Auto a2 = new Auto();
            a2.Nazev = "BMW";
            a2.Rychlost = 150;

            //Console.WriteLine($"Jméno řidiče:  {r1.Jmeno}");

            //chci po konkrétním řidiči - r1 - aby zavolal svoji funkci
            r1.VratiInfoORidici();

            //stejně jako do jakéhokoliv listu přidávám i zde, ale chci přidat do listu řidiče1
            r1.vlastnenaAuta.Add(a2);
        }
    }
}
