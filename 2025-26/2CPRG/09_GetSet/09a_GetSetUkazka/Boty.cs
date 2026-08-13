using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GetSetUkazka
{
    internal class Boty
    {
        private double Cena;
        private string nazev;
        public int velikost { get; private set; }
        
        //pokud chci mít tělo u get/set potřebuji jednu privátní vlastnost (zde nazev s malým n) a pak jednu get/set funkci s velkým N, ale bez kulatých závorek
        public string Nazev
        {
            get
            {
                return nazev;
            }
            set
            {
                if (value.Length != 0)
                {
                    nazev = value;
                }
                else
                {
                    throw new Exception("název nesmí být prázdný");
                }
            }
        }

        public Boty(double _cena, string _nazev)
        {
            Cena = _cena;
            nazev = _nazev;
        }


        //díky get/set už následující funkce nepotřebuji
        public double vratCenu()
        {
            return Cena;
        }

        public string vratNazev()
        {
            return Nazev + "přeji pěkný den.";
        }

        public void prenastavCenu(double novaCena)
        {
            Cena = novaCena;
        }

    }
}
