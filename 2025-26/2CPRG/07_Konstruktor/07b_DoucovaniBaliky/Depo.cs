using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolucovani
{
    internal class Depo
    {
        List<Balik> seznamBaliku = new List<Balik>();

        //depo dostane hotový balík a nezajímá ho, co je uvnitř, prostě balík vezme a uloží si ho do svého listu
        public void pridejBalik(Balik balik)
        {
            seznamBaliku.Add(balik);
        }

        public string vypisInfoOVsechBalicich()
        {
            string vysledek = "";
            foreach (Balik item in seznamBaliku)
            {
                vysledek += item.VratInfo();
                vysledek += "\n";
            }
            return vysledek;
        }

        public int vratNedorucene()
        {
            int x = 0;
            foreach (Balik item in seznamBaliku)
            {
                if (item.StavDoruceni == 2)
                {
                    x++;
                }    
            }
            return x;
        }

        public int spocitejDorucene()
        {
            int x = 0;
            foreach (Balik item in seznamBaliku)
            {
                if (item.StavDoruceni == 1)
                {
                    x++;
                }
            }
            return x;
        }

        public int spocitejJesteNedorucovane()
        {
            int x = 0;
            foreach (Balik item in seznamBaliku)
            {
                if (item.StavDoruceni == 0)
                {
                    x++;
                }
            }
            return x;
        }

        public int spocitejDleZadani(int stav)
        {
            int x = 0;
            foreach (Balik item in seznamBaliku)
            {
                if (item.StavDoruceni == stav)
                {
                    x++;
                }
            }
            return x;
        }

        public void dorucJeden()
        {
            foreach (Balik item in seznamBaliku)
            {
                if (item.StavDoruceni == 0)
                {
                    item.DorucBalik();
                    break;
                }
            }
        }

        //nedává smysl, aby depo za mě vytvářelo nový balik
        //public void pridejBalik(string prijemce, int cisloObjdnavky)
        //{
        //    Balik b = new Balik(cisloObjdnavky, prijemce);
        //    seznamBaliku.Add(b);
        //}
    }
}
