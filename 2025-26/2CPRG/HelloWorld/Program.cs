using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            komentář přes
            více řádků
            */

            //komentář na jeden řádek

            //celočíselný datový typ
            int mojeCislo = 42;

            //desetinné číslo
            float f = 42.5f;
            double d = 42.54543;
            decimal dd = 0;
            long l = 5;

            //text, píše se do dvojtých uvozovek
            string s = "asdfasdf";

            //jeden znak, píše se do jednoduchých uvozovek
            char c = 'x';

            //hodnota true nebo false
            bool b = true;

            //pracuji s konzolí: Console
            //chci po ní, aby něco udělala: tečka
            //Funkce WriteLine vypisuje a odenteruje

            //Pro čtení vstupu z konzole používám Console.ReadLine()
            //výstup z metody ReadLine() si uložím do proměnné
            Console.WriteLine("Zadej svoje jméno");
            string jmeno = Console.ReadLine();
            Console.WriteLine($"Ahoj {jmeno} !");

            Console.WriteLine("Zadej věk");
            //chci pracovat s číslem, ale je to pořád string
            //int vek = Convert.ToInt32(Console.ReadLine());
            //pokud uživatel napíše něco jiného než číslo,
            //aplikace spadne, protože neumí převádět nic jiného

            //Metoda TryParse se pouze pokusí převést, pokud se podaří, vrací true
            //a do hodnoty výsledek uloží převedené číslo, jinak vrací false
            int vysledek;
            if (Int32.TryParse(Console.ReadLine(), out vysledek))
            {
                //Pouze pokud se mi podaří úspěšně převést, mohu s číslem dál pracovat

                Console.WriteLine("ok");
                if (vysledek > 18)
                {
                    Console.WriteLine("Bylo ti už 18");
                }
                else if (vysledek == 18)
                {
                    Console.WriteLine("Je ti právě 18");
                }
                else
                {
                    Console.WriteLine("18 ti bude za " + (18 - vysledek));
                }
            }
            else
            {
                Console.WriteLine("not ok");
            }
        }
    }
}
