using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    internal class Adresa
    {
        string Ulice;
        string Mesto;
        string cp;

        public Adresa(string _Ulice, string _Mesto, string _cp)
        {
            Ulice = _Ulice;
            Mesto = _Mesto;
            cp = _cp;
        }

    }
}
