using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektyInstanceTridy
{
    internal class Adresa
    {
        string Ulice;
        string Cp;
        public string Mesto;
        string Psc;

        public Adresa(string ulice, string cp, string mesto, string psc)
        {
            Ulice = ulice;
            Cp = cp;
            Mesto = mesto;
            Psc = psc;
        }

        public string vratPsc()
        {
            return Psc;
        }
    }
}
