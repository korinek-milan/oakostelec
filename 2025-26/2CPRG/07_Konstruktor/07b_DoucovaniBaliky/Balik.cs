using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolucovani
{
    internal class Balik
    {
        /*
         číslo balíku,
            jméno příjemce,
            hmotnost - vygenerováno náhodně v rozsahu 1 - 10 včetně!
            stav doručení (0, 1, 2) - na začátku vždy 0 (ještě nedoručováno), 1 = doručeno úspěšně, 2 = neúspěšné doručení
         */

        int CisloBaliku;
        string Prijemce;
        double Hmotnost;
        public int StavDoruceni { get; private set; } = 0;
        static Random r = new Random();

        public Balik(int _CisloBaliku, string _Prijemce)
        {
            CisloBaliku = _CisloBaliku;
            Prijemce = _Prijemce;

            
            //Hmotnost = r.NextDouble() * 10 + 1;
            Hmotnost = Math.Round(r.NextDouble() + r.Next(1, 11), 2);
            StavDoruceni = 0;
        }

        public void nastavHmotnost(double NovaHmotnost)
        {
            Hmotnost = NovaHmotnost;
        }

        public string VratInfo()
        {
            string info = $"Cislo baliku: {CisloBaliku}, příjemce: {Prijemce}, hmotnost: {Hmotnost}, stav: {prevedStav()}";
            return info;
        }

        public string prevedStav()
        {
            if (StavDoruceni == 2)
            {
                return "Neúspěšně doručeno";
            }
            else if (StavDoruceni == 1)
            {
                return "Doručeno úspěšně";
            }
            else
            {
                return "Ještě nedoručeno";
            }

        }

        public void DorucBalik()
        {
            if (r.Next(1, 11) <= 7)
            {
                StavDoruceni = 1;
            }
            else
            {
                StavDoruceni = 2;
            }
        }

    }
}


