using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string = pouze textová hodnota
            //string, int, double, float, bool, char
            //int x = "6" + "6"; // 66
            int y = Convert.ToInt32("6");
            //Parse, TryParse
            int z = 6 + y;

            //přetypování zde ořízne desetinnou část
            int mojePromenna = Convert.ToInt32(6.4);
            double a = 6;
            //double a = 10; už existuje, pro použití nesmím psát datový typ
            a = 10;
            double aa = 10;

            //zápis vstupu do konzole
            //writeLine umí různé datové typy
            Console.WriteLine("abc");
            Console.WriteLine(a);

            //čtení z konzole
            //Console.ReadLine nikdy nebude stát sám o sobě, protože by se vstup od uživatele zahodil
            //ReadLine() umí vracet pouze string
            //string vstup = Console.ReadLine();
            //int nejakeCislo = Convert.ToInt32(vstup);

            //int hotoveCislo = Convert.ToInt32(Console.ReadLine());

            //objekt, který umí generovat náhodná čísla, sám o sobě není náhodné číslo
            Random r = new Random();
            //Funkce next, generuje náhodná čísla
            //náhodné číslo
            //náhodné číslo od nuly do hranice, která tam nepatří
            //náhodné číslo od minima, které tam patří, do horní hranice, která tam nepatří
            int nahodneCislo = r.Next();

            //Pole
            bool[] poleBoolu = new bool[5];
            Random[] poleRandomu = new Random[10];
            //pokud znám hodnoty, mohu je do složené závorky vypsat
            //nemusím psát počet položek, program si to zjistí sám z vypsaných hodnot
            string[] poleStringu = new string[] {"a", "abc", "xyz", "74", "Jonáš" };

            //chci z pole "poleStringu" vypsat hodnotu na indexu 2 -> tzn. třetí pozice
            Console.WriteLine(poleStringu[2]);
            //neumí vypsat celý objekt, pouze vrátí název datového typu
            Console.WriteLine(poleStringu);
            //co by to vypsalo ze? Je to jen objekt, co umí generovat náhodná čísla, co by se mělo vypsat do konzole?
            Console.WriteLine(r);

            //jak vypsat vše?
            Console.WriteLine(poleStringu[0]);
            Console.WriteLine(poleStringu[1]);
            Console.WriteLine(poleStringu[2]);
            Console.WriteLine(poleStringu[3]);
            Console.WriteLine(poleStringu[4]);

            //co když chci vypsat všechny studenty na škole? Nechci kopírovat 400x řádek a psát index
            //lepší je použít nějaký cyklus, který to za mě řeší sám

            //foreach si sám na pozadí udělá následující příkaz
            //string
            //item = poleStringu[0];
            //vykoná tělo a jde dál
            //zvýší si číslo indexu, který má číst
            //item = poleStringu[1];
            foreach (string item in poleStringu)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < poleStringu.Length; i++)
            {
                //pozor, takto vypíše pokaždé prvek na indexu 0
                //string item = poleStringu[0];
                string item = poleStringu[i];
                Console.WriteLine(item);

                //for cyklus mi umožňuje pracovat i s jiným indexem, než na kterém zrovna jsem
                //musím si dát pozor, že nesahám mimo pole, proto je potřeba nějaký if
                if (i < 4)
                {
                    Console.WriteLine(poleStringu[i + 1]);
                }

                //zkrácený zápis bez mezikroku pro vytvoření proměnné
                //Console.WriteLine(poleStringu[i]);
            }

            //úplně stejně bych pracoval s polem objektů Random
            /*foreach (Random item in poleRandomu)
            {

            }*/


            //zápis do pole
            int x = 5;
            x = 42;

            //upravuji jednu z přihrádek (dané indexem) v poleStringu
            poleStringu[0] = "a";
            poleStringu[1] = "x";
            poleStringu[2] = "z";


            string[] jinePoleStringu = new string[5];
            //zde vezmu celé pole a uložím ho do jiného pole
            jinePoleStringu = poleStringu;

            int[] poleIntu = new int[5];
            for (int i = 0; i < poleIntu.Length; i++)
            {
                poleIntu[i] = r.Next();
            }

            bool whileBezi = true;
            while (whileBezi)
            {

                //následující menu není dopsané
                Console.WriteLine("Menu");
                Console.WriteLine("1 - sčítání");
                Console.WriteLine("2 - odčítání");
                Console.WriteLine("99 - konec");


                string hodnota = "99";
                //uživatel zadá 99, if je pravidvý, nastaví proměnnou whileBezi na false,
                //v následující iteraci while končí
                if (hodnota == "99")
                {
                    whileBezi = false;
                }
            }

            //List
            int abc = 42;
            string[] ps = new string[5];
            List<string> listStringu = new List<string>();
            listStringu.Add("abc");
            listStringu.Add("xyz");
            listStringu.Add("42");

            //mohu se dotázat na index, indexy interně existují
            Console.WriteLine(listStringu[1]);

            //pokud se dotážu na neexistující index, spadne mi to stejně jako u pole
            //Console.WriteLine(listStringu[60]);

            //odebere první výskyt zadané hodnoty
            listStringu.Remove("xyz");

            //nic to nevymaže, ale nespadne
            listStringu.Remove("nezname slovo");

            //odstraní položku na zadaném indexu
            listStringu.RemoveAt(0);

            //index neexistuje, program spadne
            //listStringu.RemoveAt(60);

            //výpis probíhá úplně stejně jako u pole
            //rozdíl je v tom, že list nemá length, ale Count
            //listStringu.Count

            /*foreach (string item in listStringu)
            {

            }

            for (int i = 0; i < listStringu.Count; i++)
            {

            }*/

            int xx = 42;
            int yy = 8;

            //void funcke se zavolá jen tak bez přiřazení nebo výpisu
            obecnaFunkce();

            //u funkce s návratovou hodnotou - zde scitani vraci int - chceme s tím výsledkem něco dělat
            //zde např. vypsat do konzole nebo dál počítat
            Console.WriteLine(scitani(xx, yy));
            Console.WriteLine(scitani(42, yy));
            Console.WriteLine(scitani(yy, xx));

            int nejakyVypocet = 123 + scitani(yy, xx);

            //lze řetězit vstupy funkcí
            Console.WriteLine(scitani(xx, r.Next(Convert.ToInt32("12"))));

            //obecna funkce "vrací" void -> nevrací nic
            //WriteLine neumí vypsat void
            //Console.WriteLine(obecnaFunkce());
        }

        //static píšu vždy, pokud je to funkce v Program.cs
        //public říká viditelnost
        //void návratový datový typ, který nic nevrací, není potřeba return
        //int - funkce slibuje, že vrátí číslo
        //název funkce - jakýkoliv
        //kulaté závorky říkají datové typy, které po nás ta funkce chce, aby mohla fungovat
        static public void obecnaFunkce()
        {
            //něco udělá, ale nic nevrací
        }

        static public int scitani(int a, int b)
        {
            int vysledek = a + b;
            return vysledek;

            //zkrácený zápis bez mezikroku
            //return a + b;
        }
    }
}
