using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAuta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Třída Auto - jeden atribut název, plní se přes konstruktor
                Třída Garaz - obsahuje seznam aut, obsahuje funkci na přidávání aut do seznamu
                V program.cs - vytvořte 2x instanci auto, přidejte do garaze,
                vypište...počet všech aut v garáži (ne natvrdo 2)
             */

            Auto a1 = new Auto("červený");
            Auto a2 = new Auto("bobík");

            Garaz g = new Garaz();

            g.pridejAuto(a1);
            g.pridejAuto(a2);

            Console.WriteLine(g.pocetAutVGarazi());
            Console.WriteLine(g.seznamAut.Count);
        }
    }
}
