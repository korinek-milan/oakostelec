using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class Produkt
    {
        string Nazev;
        private double Cena;

        public Produkt(string _Nazev, double _Cena)
        {
            Nazev = _Nazev;
            Cena = _Cena;
        }

        //Pokud mám atribut private, musím ale ostatním umožnit "nějak" ten atribut alespoň číst
        public double VratCenu()
        {
            return Cena;
        }
    }
}
