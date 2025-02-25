using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatoveTypy
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int stareCislo = 5; // naplnim hodnotu a chci ji poslat pouze referenci = bude se aktualizovat hned
            myFuncRef(ref stareCislo);//klicove slovo ref
            Console.WriteLine(stareCislo);//aniz bych neco vracel z funkce pomoci return, hned bude hodnota zmenena


            int OutCislo;//pouze si pripravim promennou jako schranku, neobsahuje zadne hodnoty
            myFuncOut(out OutCislo);//pouziji klicove slovo out
            Console.WriteLine(OutCislo);//aniz bych neco vracel z funkce pomoci return, hned bude hodnota zmenena



            //mam tri hodnoty a potrebuji je vsechny upravit ve funkci
            int x = 1;
            int y = 2;
            int z = 3;
            myFuncMultipleParams(ref x, ref y, ref z);

            //muzu hned vypisovat promenne, bez toho, abych je nejak presouval pomoci pole
            Console.WriteLine(x.ToString() + " " + y.ToString() + " " + z.ToString());
            
            Console.ReadLine();
        }

        public static void myFuncRef(ref int cislo)
        {
            cislo = cislo + 1;
            //nic nevracim, samo se to propise pres ref -> pres odkaz do pameti
        }

        public static void myFuncOut(out int cislo)
        {
            cislo = 5;
            //nic nevracim, samo se to propise pres ref -> pres odkaz do pameti
        }

        public static void myFuncMultipleParams(ref int x, ref int y, ref int z)
        {
            x = x + 1;
            y = y + 1;
            z = z + 1;

            //funkce neumi vracet vice veci, musel bych nacpat hodnoty do pole nebo struktury
            //pokud bych mel ruzne datove typy, napr. (int x, int y, string z), nemuzu je nacpat do pole, musim pouzit struct
            //int[] pole = new int[3];
            //pole[0] = x;
            //pole[1] = y;
            //pole[2] = z;


            //diky ref, se vse hned propise, takze nic nevracim
            //return pole;
        }
    }
}
