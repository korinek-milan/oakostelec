using System;
using System.Collections.Generic;
using System.Text;

namespace UvodV2
{
    internal class Auto
    {
        public int pocetKol { get; private set; }
        public string znackaAuta { get; private set; }
        public int mnozstviPaliva { get; private set; }

        public Auto(int _pocetKol, string znackaAuta)
        {
            pocetKol = _pocetKol;
            this.znackaAuta = znackaAuta;
            mnozstviPaliva = 5;
        }

        public void zmenaPoctuKol(int novyPocet)
        {
            pocetKol = novyPocet;
        }
    }
}
