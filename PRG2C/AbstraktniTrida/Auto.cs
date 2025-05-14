using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktniTrida
{
    internal class Auto: Vozidlo
    {
        public bool maKufr;

        public Auto(string _Nazev, bool _maKufr): base(_Nazev)
        {
            this.maKufr = _maKufr;
        }
        public override string VratInfo()
        {
            return nazev + " " + maKufr;
        }

        public override string VratNazev()
        {
            return base.VratNazev();
        }
    }
}
