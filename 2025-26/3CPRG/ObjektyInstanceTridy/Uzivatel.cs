using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektyInstanceTridy
{
    internal class Uzivatel
    {
        string Jmeno;
        int Vek;
        Adresa Adresa = null;

        public Uzivatel(string jmeno, int vek, Adresa adresa)
        {
            Jmeno = jmeno;
            Vek = vek;
            Adresa = adresa;
        }

        public Uzivatel(string jmeno, int vek, string mesto, string psc, string ulice, string cp)
        {
            Jmeno = jmeno;
            Vek = vek;
            
            Adresa = new Adresa(ulice, cp, mesto, psc);
            //Adresa.Mesto = mesto; instance jeste neexistuje
        }

        public Uzivatel()
        {
            
        }

        public bool prihlasSeDoSite()
        {
            Random r = new Random();
            if (r.Next(2) == 1)
            {
                return true;
            }

            return false;
        }

        public Adresa vratAdresu()
        {
            return Adresa;
        }
    }
}
