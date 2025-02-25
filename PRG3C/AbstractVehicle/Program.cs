using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AbstractVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vozidlo v = new Vozidlo(); nelze vytvořit instanci abstraktní třídy

            //muzu zavolat static metodu i bez instance, protoze static metoda je navázkanáo na třídu, ne na instanci
            Console.WriteLine(Auto.vypisMiPocetAut());

            Auto a = new Auto(4, 150, 4, 10);
            Auto a2 = new Auto(5, 100, 5, 11);

            //instance nemohou volat statické metody
            //a.vypisMiPocetAut();

            Console.WriteLine(Auto.vypisMiPocetAut());

            Console.WriteLine(Auto.statickaMetodaSParametrem(42));

            Kolo k = new Kolo(true, 10, 2, 5);


            //toto je spatne, chci mit jednu kolekci a ne samostatne pro kazdy typ
            //Auto[] vozidlaA = new Auto[2];
            //Kolo[] vozidlaK = new Kolo[2];

            //varianta pole:
            //Mam obecny typ Vozidlo, coz je predchudce jak Auta, tak Kola
            //proto mohu do pole typu Vozidlo nacpat tyto zdedene tridy
            Vozidlo[] vozidla = new Vozidlo[10];//připravím si velikost pole
            Vozidlo[] vozidla2 = { a, k };//hned naplním, proto není potřeba říct velikost předem


            vozidla[0] = a;
            vozidla[2] = k;

            foreach (Vozidlo v in vozidla)
            {
                //pole mám deset prvků dlouhé, tzn. některé hodnoty jsou prázdné, pokud bych je vypsla, nastane chyba
                if (v == null)
                {
                    continue;
                }
                //metoda vypisInfo je ve tride Vozidlo, takze ji znaji obe zdedene tridy
                //proto ji mohu zavolat
                Console.WriteLine(v.vypisInfo());

                //způsob ověření konkrétní třídy
                //if (v.GetType() == typeof(Auto))
                //{

                //}

                //klíčové slovo is je jednodušší vestavěný způsob, jak ověřit specifický typ
                if (v is Auto)
                {
                    //abych mohl přistupovat ke konkrétnímu prvku, musím si vytvořit novou lokální proměnnou toho specifikého typu
                    //a následně přetypovoat tu obecnou proměnnou
                    Auto aa = (Auto)v;
                    Console.WriteLine(aa.specifickaMetodaProAuto());//zde už volám specifikou metodu obvyklým způsobem
                }
            }


            //varianta list:
            Console.WriteLine();

            List<Vozidlo> vozidlaList = new List<Vozidlo>();

            vozidlaList.Add(a);
            vozidlaList.Add(k);

            foreach (Vozidlo v in vozidlaList)
            {
                Console.WriteLine(v.vypisInfo());
            }


            Console.ReadLine();
        }
    }
}
