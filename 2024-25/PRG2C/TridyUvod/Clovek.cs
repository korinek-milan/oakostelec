using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyUvod
{
    internal class Clovek
    {
        //attributy tridy - bez urceni = private -> nejsou videt z venku
        string barvaOci;
        int vyska;
        int vek;
        bool alive = true;//defaultni hodnota true

        //Konstruktor - specialni metoda, ktera se jmenuje jako trida a vola se vzdy pri vytvoreni instance
        public Clovek(string _barvaOci, int _vyska, int _vek, bool _alive)
        {
            barvaOci = _barvaOci;
            vyska = _vyska;
            nastavVek(_vek);
            alive = _alive;
        }

        //privatni funkce nebude videt z venku
        private void beh()
        {
            
        }

        //nechci nastavit vek primo, ale chci mit nejakou kontrolu, proto nastavuji vek pres tuto metodu
        public void nastavVek(int v)
        {
            if (v > 100)
            {
                vek = 100;
            }
            else
            {
                vek = v;
            }
            
        }

        public bool jeZivy()
        {
            return alive;
        }

        public bool jeVyskaDostacujici(int kontrolniVyska)
        {
            if (vyska < kontrolniVyska)
            {
                return true;
            }

            return false;
        }

        //nikdy ve tride nevypisuji primo do konzole, pouze vracim string a ten, kdo to chce si to vypise
        public string vypisBarvuOci()
        {
            return barvaOci;
        }

        public void nactiBarvuOci(string barvaOci)
        {

        }
    }
}
