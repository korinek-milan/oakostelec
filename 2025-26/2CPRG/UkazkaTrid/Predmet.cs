using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UkazkaTrid
{
    internal class Predmet
    {
        public string Nazev;
        public string JmenoVyucujiciho;

        public void InformaceOPredmetu()
        {
            Console.WriteLine($"Předmět se jmenuje {Nazev} a učí ho {JmenoVyucujiciho}");
        }

        public void vypisNazevPredmetu()
        {
            Console.WriteLine("Název předmětu" + Nazev);
        }
    }
}
