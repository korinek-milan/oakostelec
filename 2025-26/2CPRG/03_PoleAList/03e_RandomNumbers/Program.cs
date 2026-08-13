using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //funkce, kde uživatel hádá dokud neuhodne
            //hadejDoNekonecna();

            //omezený počet pokusů
            hadejXKrat();
        }

        static void hadejXKrat()
        {
            //třída random, která nám umožňuje generovat náhodná čísla
            Random rnd = new Random();
            int tajneCislo = rnd.Next(11);

            Console.WriteLine("Hádej číslo od 0 do 10");


            //Console.WriteLine(tajneCislo);
            //něco čtu od uživatele - je to vždy string
            string vstupOdUzivatele = Console.ReadLine();

            //převedu string na číslo
            int prevedeneCislo = Int32.Parse(vstupOdUzivatele);
            int pocetPokusu = 3;
            int pokusu = 1;

            //while běží dokud je podmínka pravdivá
            //dokud uživatelovo číslo bude jiné != ne-rovná se tajnému číslu
            //&& a zároveň
            //moje pokusy jsou menší než (maximální) počet pokusů
            while ((prevedeneCislo != tajneCislo) && (pokusu < pocetPokusu))
            {
                Console.WriteLine("smůla, zkus to znovu");
                Console.WriteLine("Hádej číslo od 0 do 10");
                vstupOdUzivatele = Console.ReadLine();
                prevedeneCislo = Int32.Parse(vstupOdUzivatele);
                pokusu += 1;
            }

            //musím zjistit, jestli while byl ukončen protože jsem uhodl nebo protože došly pokusy
            if (prevedeneCislo == tajneCislo)
            {
                Console.WriteLine("vyhrál jsi na " + pokusu + ". pokus");
            }
            else
            {
                Console.WriteLine("smůla, pokusy došly");
            }

        }

        static void hadejDoNekonecna()
        {
            Random rnd = new Random();
            int tajneCislo = rnd.Next(11);

            Console.WriteLine("Hádej číslo od 1 do 10");

            Console.WriteLine(tajneCislo);
            string vstupOdUzivatele = Console.ReadLine();

            int prevedeneCislo = Int32.Parse(vstupOdUzivatele);


            while (prevedeneCislo != tajneCislo)
            {
                Console.WriteLine("smůla, zkus to znovu");
                Console.WriteLine("Hádej číslo od 1 do 10");
                vstupOdUzivatele = Console.ReadLine();
                prevedeneCislo = Int32.Parse(vstupOdUzivatele);
            }


            Console.WriteLine("vyhrál jsi");
        }
    }
}
