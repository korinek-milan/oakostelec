using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    internal class Car : Vehicle
    {
        int PocetDveri;

        public Car(int pocetKol, double cena, bool svetla, string nazev, int pocetDveri) : base(pocetKol, cena, svetla, nazev)
        {
            PocetDveri = pocetDveri;
        }

        public void OtevriDvere()
        {
            Console.WriteLine("Dveře otevřeny");
        }
    }
}
