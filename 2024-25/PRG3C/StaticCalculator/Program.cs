using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;
            
            float.TryParse(Console.ReadLine(), out x);
            float.TryParse(Console.ReadLine(), out y);

            //Toto není možné u statické třídy
            //Kalkulacka k = new Kalkulacka();

            //zde se nic nestane, protože výsledek metody soucet dále nijak nepoužívám
            Kalkulacka.soucet(x, y);

            //výstup přímo předhodím další metodě - zde WriteLine()
            Console.WriteLine(Kalkulacka.soucet(x, y));

            //nebo si výsledek nejdříve uložím pro budoucí použití
            float vysledek = Kalkulacka.rozdil(x, y);
            Console.WriteLine(vysledek);

            Console.WriteLine(Kalkulacka.PI);

            //do konstanty nelze zapisovat
            //Kalkulacka.PI = 0;

            Kalkulacka.PISpatne = 0;
            Console.WriteLine(Kalkulacka.PISpatne);

            Console.WriteLine(Kalkulacka.pocetPouziti);

            Console.ReadLine();
        }
    }
}
