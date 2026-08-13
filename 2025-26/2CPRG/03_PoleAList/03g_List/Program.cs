using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //neřeším velikost - ta je dynamická (indexy zde stále jsou, ale přidávají se sami)
            //Předpis List<T> znamená, že za T se dosadí jakýkoliv datový (T)yp a toho datového typu bude každá jednotlivá položka toho listu
            //List<string>...List<int>...List<int[]>...List<List<string>> -> klidně list listů, ve kterých jsou stringy
            List<string> nakupniSeznam = new List<string>();

            //nemusím řešit indexy (i když tam jsou stejně jako v poli) - prostě jen přidám další prvek
            nakupniSeznam.Add("Jablka");
            nakupniSeznam.Add("Chybná položka");
            nakupniSeznam.Add("Hrušky");
            nakupniSeznam.Add("Švestky");

            //mohu jednoduše odebírat z listu - dle přesné hodnoty
            nakupniSeznam.Remove("Chybná položka");


            //mohu vypisovat pomocí foreach
            foreach (string polozka in nakupniSeznam)
            {
                Console.WriteLine(polozka);
            }
            Console.WriteLine("--------------------------");
            //Mohu se dotazovat i na konkrétní index
            Console.WriteLine(nakupniSeznam[1]);

            //pokud sáhnu na index, který neexistuje, stejně jako u pole mi to spadne na chybu
            //Console.WriteLine(nakupniSeznam[100]);

        }
    }
}
