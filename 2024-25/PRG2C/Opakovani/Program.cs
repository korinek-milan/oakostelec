using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "x";
            string s2 = "1";

            int prevedeneCislo;
            //bool uspech = Int32.TryParse(s, out prevedeneCislo);

            while (!Int32.TryParse(Console.ReadLine(), out prevedeneCislo))
            {

                Console.WriteLine("zadal jsi neplatné číso, zkus to znovu");
            }

            if(true)
            {

            }


            int s2i = Int32.Parse(s2);

            Console.WriteLine(s + s2);

            int cislo1 = 5;
            int cislo2 = 10;

            int vysledek = 10;

            Kalkulacka k = new Kalkulacka();

            k.soucet(cislo1, cislo2);

            k.soucet(5, 42);

            int mujVysledek = k.soucet(Int32.Parse(Console.ReadLine()), cislo2);

            //int mujVysledek = 52;

            Console.WriteLine(k.soucet(Int32.Parse(Console.ReadLine()), cislo2));

        }
    }
}
