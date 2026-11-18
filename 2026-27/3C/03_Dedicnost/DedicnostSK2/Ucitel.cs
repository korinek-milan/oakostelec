using System;
using System.Collections.Generic;
using System.Text;

namespace DedicnostSK2
{
    internal class Ucitel : Osoba
    {
        double VysePlatu;

        public Ucitel(double plat, string jmeno) : base(jmeno)
        {
            VysePlatu = plat;
        }

        public void PolozOtazku()
        {
            Console.WriteLine("Zadaná otázka je...");
        }
    }
}
