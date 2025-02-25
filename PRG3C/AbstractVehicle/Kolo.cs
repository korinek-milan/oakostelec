using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicle
{
    internal class Kolo: Vozidlo
    {
        bool Prehazovacka;
        public Kolo(bool _Prehazovacka, int _Rychlost, int _PocetKol, int _Zrychleni) : base(_Rychlost, _PocetKol, _Zrychleni)
        {
            Prehazovacka = _Prehazovacka;
        }

        public override string vypisInfo()
        {
            return base.vypisInfo() + ", Přehazovačka: " + this.Prehazovacka.ToString();
        }

        public override string vypisInfoZbytecnaVarianta()
        {
            return "Rychlost: " + this.Rychlost.ToString() + ", Pocet Kol: " + this.PocetKol.ToString() + ", Zrychleni: " + this.Zrychleni.ToString() + ", Přehazovačka: " + this.Prehazovacka.ToString();
        }
    }
}
