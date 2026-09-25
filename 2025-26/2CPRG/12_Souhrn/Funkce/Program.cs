using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uživatel zadá číselnou hodnotu
            //Program řekne, jestli je hodnota kladná, záporná nebo nula pomocí funkce


            double vstupOdUzivatele = 0;
            
            try
            {
                int x = 42;
                //vždy napíšu uživateli, co má zadat, jinak na něj bude blikat kurzor na prázdné stránce
                Console.WriteLine("Zadej číselnou hodnotu.");
                
                //ReadLine() vrací vždy string, tzn. musím převést na číslo, např. pomocí Convert.To...
                vstupOdUzivatele = Convert.ToDouble(Console.ReadLine());

                //zavolám funkci, pošlu do ní vstup od uživatele, výstup z funkce pošlu jako vstup do WriteLine() a vypíšu do konzole
                Console.WriteLine(RozhodovaciFunkce(vstupOdUzivatele));

                //zde může nastat chyba dělení nulou...pozor u double dělení nulou nemusí nastat, protože double není čistý
                int vysledek = 10 / (int)vstupOdUzivatele;
            }
            catch (Exception ex)//pokud nastane nějaká chyba, automaticky to skočí do catch a vykoná tělo - zde vypíše chybovou hlášku
            {
                Console.WriteLine(ex.Message);
            }

            //tato proměnná je vidět, byla tytvořena na stejné úrovni - tzn. ve stejných složených závorkách jako je umístěn další řádek
            Console.WriteLine(vstupOdUzivatele);

            //zde proměnná už neexistuje, protože byla vytvořena uvnitř složených závorek try
            //Console.WriteLine(x);
        }

        static void whileFunkce()
        {

            //zde musím ukončit while pomocí break
            while (true)
            {
                break;
            }

            //proměnná bezi lze upravit uvnitř těla a zde např. pomocí nějaké podmínky si while ukončím
            bool bezi = true;
            while (bezi)
            {

               /*if(něco se stalo)
               {
                    bezi = false;
               }*/
            }
        }

        static string RozhodovaciFunkce(double cislo)
        {
            if (cislo > 0)
            {
                return "Číslo je kladné";
            }
            else if (cislo < 0)
            {
                return "Číslo je záporné";
            }
            else
            {
                return "Číslo je nula";
            }
        }
    }
}
