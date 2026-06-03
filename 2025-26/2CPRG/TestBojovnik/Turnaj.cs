using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBojovnik
{
    static internal class Turnaj
    {
        public static List<Bojovnik> bojovnici { get; private set; } = new List<Bojovnik>();

        public static void PridejBojovnika(Bojovnik b)
        {
            bojovnici.Add(b);
        }

        public static bool JeVitez()
        {
            bool vitez = false;
            int pocetPrezivsich = 0;

            foreach (Bojovnik bojovnik in bojovnici)
            {
                if (bojovnik.JeNazivu() == true)
                {
                    pocetPrezivsich++;
                }
                if (pocetPrezivsich > 1)
                {
                    vitez = false;
                }
                else
                {
                    vitez = true;
                }
            }

            return vitez;
        }

        public static void SpustSouboj()
        {
            List<Bojovnik> souboj = new List<Bojovnik>();

            foreach (Bojovnik b in bojovnici)
            {
                if (b.JeNazivu() == true)
                {
                    souboj.Add(b);
                }
            }

            if (souboj.Count < 2)
            {
                return;
            }

            if (souboj.Count >= 2)
            {
                Bojovnik b1 = souboj[0];
                Bojovnik b2 = souboj[1];

                //toto je špatně - musí platit, že jsou oba naživu, tzn. "a zároveň" -> &&
                //while (b1.JeNazivu() == true || b2.JeNazivu() == true)
                while (b1.JeNazivu() == true && b2.JeNazivu() == true)
                {
                    b1.ZautocitNa(b2);
                    if (b2.JeNazivu() == true)
                    {
                        b2.ZautocitNa(b1);
                    }
                }
            }


        }
    }
}
