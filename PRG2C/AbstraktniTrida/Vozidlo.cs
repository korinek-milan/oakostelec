using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktniTrida
{
    internal abstract class Vozidlo
    {

        int rychlost;
        protected string nazev;

        public Vozidlo(string Nazev)
        {
            this.nazev = Nazev;
        }

        public abstract string VratInfo();

        public virtual string VratNazev()
        { return nazev; }
    }
}
