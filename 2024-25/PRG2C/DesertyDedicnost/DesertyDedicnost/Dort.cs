using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesertyDedicnost
{
    internal class Dort: Dezert
    {
        int PocetPater;
        public Dort(string _Jmeno, int _PocetKalorii, bool _JeLedovy, int _PocetPater):base(_Jmeno, _PocetKalorii, _JeLedovy)
        {
            PocetPater = _PocetPater;
        }

        public override string Vyrob()
        {
            return "Dort vyroben";
        }

        public override string VratInfo()
        {
            string s = base.VratInfo() + $", Počet pater: {PocetPater}";
            return s;
        }

        public void PridejPatro(int pocet)
        {
            PocetPater = PocetPater + pocet;
            //PocetPater += pocet;
        }
    }
}
