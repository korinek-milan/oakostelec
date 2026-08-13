using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdstranovacMezer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Odstranovac.remover("   toto je věta   ", false));
            Console.WriteLine(Odstranovac.remover("   toto je věta   ", true));
        }
    }
}
