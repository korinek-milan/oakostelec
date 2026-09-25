using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyOpakovani
{
    internal class Uzivatel
    {
        string Jmeno;
        public int Vek { get; private set; }
        int Zivoty;

        public Uzivatel(string _Jmeno, int _Vek)
        {
            Jmeno = _Jmeno;
            Vek = _Vek;
            Zivoty = 100;
        }

        public string VratJmeno()
        {
            return Jmeno;
        }

        public string nastavVekSNavratovouHlaskou(int NovyVek)
        {
            if (NovyVek < 0)
            {
                return "Věk musí být větší/rovno nule";
            }
            else
            {
                Vek = NovyVek;
                return "";
            }
        }

        public void nastavVekSMoznostiChyby(int NovyVek)
        {
            if (NovyVek < 0)
            {
                throw new Exception("Věk musí být větší/rovno nule");
            }
            else
            {
                Vek = NovyVek;
            }
        }

    }
}
