using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nelze vytvorit instanci ze staticke tridy, proto nasledujici dva radky nebudou fungovat
            //Kalkulacka k = new Kalkulacka();
            //k.soucet(2, 5);
            float a = 2;
            float b = 5;
            //Nemam instanci a statickou metodu volam primo na tridu
            Kalkulacka k = new Kalkulacka();

            Console.WriteLine(k.VratHodnotu(10));

            


            Console.ReadLine();
        }
    }
}
