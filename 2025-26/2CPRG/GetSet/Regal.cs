using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zkouseni
{
    internal class Regal
    {
        List<Kniha> seznamKnih = new List<Kniha>();

        public void pridejKnihu(Kniha k)
        {
            seznamKnih.Add(k);
        }

        public void VypisNazvy()
        {
            foreach (Kniha item in seznamKnih)
            {
                Console.WriteLine(item.VratNazev());
            }
        }

        public string VratNazvyVeStringu()
        {
            string nazvy = "";
            foreach (Kniha item in seznamKnih)
            {
                nazvy += item.VratNazev();
            }
            return nazvy;
        }

        public List<Kniha> vratSeznam()
        {
            return seznamKnih;
        }

    }
}
