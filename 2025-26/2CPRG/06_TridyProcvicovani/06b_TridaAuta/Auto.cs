using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridaAuta
{
    internal class Auto
    {
        public string Nazev;
        public int Rychlost;

        public void VratInfoOAute()
        {
            Console.WriteLine($"Název auta: {Nazev}, Rychlost: {Rychlost}");
        }
    }
}
