using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickaTridaV2
{
    internal class Uzivatel
    {
        public string Jmeno { get; private set; }

        private static int pocetVytvorenychUzivatelu = 0;

        public Uzivatel(string _Jmeno)
        {
            pocetVytvorenychUzivatelu++;
            Jmeno = _Jmeno;
        }

        public string vratJmeno()
        {
            return Jmeno;
        }

        static public int vratPocetUzivatelu()
        {
            return pocetVytvorenychUzivatelu;
        }
    }
}
