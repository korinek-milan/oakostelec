using System;
using System.Collections.Generic;
using System.Text;

namespace DedicnostOverride
{
    internal class Auto: Vozidlo
    {

        //pomocí klíčového slova override říkám, že přepisuji chování rodičovské funkce
        public override void vydejZvuk()
        {
            //base.vydejZvuk(); // pokud chci, mohu zavolat rodičovskou funkci
            
            //zde si přidám něco vlastního
            Console.WriteLine("Troubím");
        }


        //tuto funkci musím povinně "přepsat", protože v rodiči je pouze abstraktní a nemá žádné tělo
        public override void funkceNemaSmyslZPohleduRodice()
        {
            Console.WriteLine("Zde dělám něco, co má smysl z pohledu třídy Auto");
        }
    }
}
