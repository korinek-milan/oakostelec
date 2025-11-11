using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesertyDedicnost
{
    internal class Dezert
    {
        string Jmeno;
        int PocetKalorii;
        bool JeLedovy;

        public Dezert(string _Jmeno, int _PocetKalorii, bool _JeLedovy)
        {
            Jmeno = _Jmeno;
            PocetKalorii = _PocetKalorii;
            JeLedovy = _JeLedovy;
        }

        public virtual string Vyrob()
        {
            return "Vyrobeno";
        }

        public virtual string VratInfo()
        {
            return $"Jméno: {Jmeno}, Kalorie: {PocetKalorii}, Je ledový? {JeLedovy}";
        }
    }
}
