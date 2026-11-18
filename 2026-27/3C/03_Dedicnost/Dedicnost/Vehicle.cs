using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    //nadřazená třída, něco obecného, neříká mi to, jestli je to auto, náklaďák, kolo nebo něco jiného
    internal class Vehicle
    {
        int PocetKol;
        double Cena;
        bool Svetla;

        string Nazev;

        public Vehicle(int pocetKol, double cena,bool svetla, string nazev)
        {
            PocetKol = pocetKol;
            Cena = cena;
            Svetla = svetla;
            Nazev = nazev;
        }

        public string vratNazev()
        {
            return Nazev;
        }
    }
}
