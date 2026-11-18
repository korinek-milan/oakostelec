using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    internal class Bicycle : Vehicle
    {
        string typSlapek;
        int PrevodovyStupen;

        public Bicycle(int pocetKol, double cena, bool svetla, string nazev) : base(pocetKol, cena, svetla, nazev)
        {
            
        }

        public void NastavPrevodovyStupen(int stupen)
        {
            PrevodovyStupen = stupen;
        }

    }
}
