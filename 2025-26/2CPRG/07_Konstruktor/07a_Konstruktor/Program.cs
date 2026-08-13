using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adresa a = new Adresa("Novákova", "Kostelec", "42");
            Student s1 = new Student("Karel", 1950, a);
            //Console.WriteLine(s1.Jmeno);

            //s1.vypis vrátí string, nic za mě vypisovat nebude...vezmu to jako vstup do Console.WriteLine() a vypíšu si to sám
            Console.WriteLine(s1.vypis());
        }
    }
}
