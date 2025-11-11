using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaDB
{
    internal class Kniha
    {
        public string autor;
        public string nazev;
        public int rokVydani;

        public Kniha(string autor, string nazev, int rokVydani)
        {
            this.autor = autor;
            this.nazev = nazev;
            this.rokVydani = rokVydani;
        }
    }
}
