using System;
using System.Collections.Generic;
using System.Text;

namespace DedicnostOverride
{
    //pokud nechci, aby vznikala instance této třídy a slouží pouze jako rodič, který předepisuje atributy a funkce,
    //třídu označím jako abstraktní
    internal abstract class Vozidlo
    {
        //pomocí klíčového slova virtual dávám potomkům možnost si tuto funkci přepsat podle sebe
        public virtual void vydejZvuk()
        {
            Console.WriteLine("Vydávám neurčitý zvuk");
        }

        //pokud je funkce napsaná jako abstraktní, pouze říká, tento název existuje a potomci ji musí povinně implementovat
        //funkce nemá tělo a na konci je středník
        public abstract void funkceNemaSmyslZPohleduRodice();

    }
}
