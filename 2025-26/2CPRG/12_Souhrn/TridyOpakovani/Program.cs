using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyOpakovani
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int x = 42;
            string s = "";
            //instance třídy Uzivatel vytvářím podobně jako jednoduchou proměnnou
            //datový typ: Uzivatel
            //název: u1
            //přiřazení je zde složitější, používám new a konstruktor
            Uzivatel u1 = new Uzivatel("Karel", 25);
            Uzivatel u2 = new Uzivatel("Jirka", 17);
            Uzivatel u3 = new Uzivatel("Karel", 25);

            //List umí všechny datové typy, takže i instance typu Uzivatel
            List<Uzivatel> uzivatele = new List<Uzivatel>();
            uzivatele.Add(u1);
            uzivatele.Add(u2);
            uzivatele.Add(u3);

            //nejdřív vyberu instanci, se kterou chci pracovat, přes tečku se dotážu na její public vlastnosti a metody
            //metody s návratovou hodnotou chci nejspíš dál použít, zde např. výpis do konzole
            Console.WriteLine(u3.VratJmeno());

            //zde přistupuji přímo k vlastnosti díky Get
            Console.WriteLine(u3.Vek);

            //try-catch píšu všude, kde může nastat nějaká chyba, typicky vstup od uživatele
            try
            {
                //zde je vstup v pořádku
                u3.nastavVekSMoznostiChyby(42);
                //zde je chybný vstup, skončí výjimkou
                u1.nastavVekSMoznostiChyby(-1);
            }
            catch (Exception ex)//odchytáváme nejobecnější výjimku (pod ní spadají všechny výjimky), výjimka je uložená do proměnné ex a dále s ní mohu pracovat
            {
                //Message je vlastnost výjimky a přes ex k ní mohu přistupovat
                Console.WriteLine(ex.Message);
            }

            //do proměnné si uložím výsledek operace
            string vysledekOperace = u3.nastavVekSNavratovouHlaskou(-1);

            //výsledek operace kontroluji a pokud je neprázdný, znamená to, že bylo něco špatně
            if (vysledekOperace != "")
            {
                Console.WriteLine(vysledekOperace);
            }

            //toto se vypíše pouze v případě, že nenastala chyba v programu
            Console.WriteLine("Úspěšný konec programu");
        }


    }
}
