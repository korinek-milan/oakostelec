using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class PolozkaKosiku
    {
        private Produkt Produkt;
        int Mnozstvi;

        public PolozkaKosiku(Produkt _Produkt, int _Mnozstvi)
        {
            Produkt = _Produkt;
            //tím, že nemám Mnozstvi public, mám kontrolu nad tím, co si do své instance uložím
            if (_Mnozstvi < 0)
            {
                throw new Exception("Množství nemůže být záporné");
            }
            Mnozstvi = _Mnozstvi;
        }


        public double CenaCelkem()
        {
            double cenaCelkem = Mnozstvi * Produkt.VratCenu();
            return cenaCelkem;
        }

        public Produkt vratProdukt()
        {
            return Produkt;
        }
    }
}
