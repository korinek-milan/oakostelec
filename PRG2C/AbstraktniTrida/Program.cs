using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktniTrida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nelze udelat instanci z abstraktni tridy
            //Vozidlo v = new Vozidlo();

            Auto a = new Auto("moje auto", false);
            Console.WriteLine(a.VratInfo());
        }
    }
}
