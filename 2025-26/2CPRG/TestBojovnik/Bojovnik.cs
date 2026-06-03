using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBojovnik
{
    internal class Bojovnik
    {
        public string Jmeno { get; private set; }
        public int Zivoty { get; private set; }
        public int SilaUtoku { get; private set; }
        public int Obrana { get; private set; }

        

        public Bojovnik(string _Jmeno)
        {
            Jmeno = _Jmeno;
            Zivoty = 50;
            Random r = new Random();
            SilaUtoku = r.Next(5, 11);
            Obrana = r.Next(5, 11);
        }

        public bool JeNazivu()
        {
            bool hodnota = false;
            if (Zivoty > 0)
            {
                hodnota = true;
            }

            return hodnota;
        }

        public void ZautocitNa(Bojovnik nepritel)
        {
            Random r = new Random();
            int hodnota = r.Next(1, SilaUtoku + 1);
            int zraneni = hodnota - nepritel.Obrana;

            if (zraneni < 0)
            {
                zraneni = 0;
            }

            nepritel.Zivoty = nepritel.Zivoty - zraneni;
        }
    }
}
