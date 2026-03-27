using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zkouseni
{
    internal class Kniha
    {
        private string nazev;//vlastnost private, s malým písmenem

        private int pocetStran;
        public string Autor { get; private set; }//Get/Set, nad kterým mám kontrolu pouze z pohledu viditelnosti - můžu číst, nemůžu zapsat

        //specifická get/set funkce (bez kulatých závorek), která mi umožní ovlivnit co nastavuji a co vracím díky tomu, že get/set zde mají tělo
        public string Nazev //obvykle se jmenuje stejně jako vlastnost, ale s velkým písmenem
        {
            get// get metoda s tělem
            {
                return nazev + "něco, protože můžu díky tělu"; 
            }
            set// set metoda s tělem
            {
                if (value.Length > 0)
                {
                    nazev = value;//klíčové slovo value obsahuje hodnotu, kterou chci nastavit někde z venku přes rovná se (=)
                }
            }
        }

        public Kniha(string _Nazev)
        {
            nazev = _Nazev;
        }

        //vlastní funkce na vrácení názvu
        public string VratNazev()
        {
            return Nazev;
        }
         
        //vlastní funkce na uložení nové hodnoty
        public void prejmenujKnihu(string novyNazev)
        {
            nazev = novyNazev;
        }
    }
}
