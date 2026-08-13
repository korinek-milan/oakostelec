using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Ovoce
    {
        private string nazev;
        public double hmotnost { get; private set; }

        public Ovoce()
        {
            Random r = new Random();

            nazev = "neurčito";
            hmotnost = new Random().Next();

        }

        public Ovoce(string _nazev, double _hmotnost)
        {
            Random r = new Random();

            nazev = _nazev;
            hmotnost = _hmotnost;

        }

    }
}
