using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicle
{
    internal abstract class Vozidlo
    {
        protected int Rychlost;
        protected int PocetKol;
        protected int Zrychleni;


        public Vozidlo(int _Rychlost, int _PocetKol, int _Zrychleni)
        {
            Rychlost = _Rychlost;
            PocetKol = _PocetKol;
            Zrychleni = _Zrychleni;

        }

        //pokud zdedena trida chce, muze tuto metodu prepsat pomoci override
        public virtual string vypisInfo()
        {
            return "Rychlost: " + this.Rychlost.ToString() + ", Pocet Kol: " + this.PocetKol.ToString() + ", Zrychleni: " + this.Zrychleni.ToString();
        }

        //tato metoda je abstraktni a proto nema telo
        //vynucuji si jeji implementaci ve zdedenych tridach
        public abstract string vypisInfoZbytecnaVarianta();

    }
}
