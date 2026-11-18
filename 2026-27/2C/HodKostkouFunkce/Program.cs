namespace HodKostkouFunkce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                
            }
        }

        static int HodKostkou()
        {
            Random r = new Random();

            //zkrácená varianta
            //return r.Next(1, 7);

            int nahodnaHodnota = r.Next(1, 7);

            return nahodnaHodnota;
        }

        static int HodDvemaKostkami()
        {
            int nahodna1 = HodKostkou();
            int nahodna2 = HodKostkou();

            return nahodna1 + nahodna2;
        }

        static bool HodTremiKostkami()
        {
            int nahodna1 = HodKostkou();
            int nahodna2 = HodKostkou();
            int nahodna3 = HodKostkou();

            //if nahodna1 = 2 nebo = 4 ...

            //% je zbytek po celočíselném dělení

            // && (RAlt + C) znamená a zároveň...jeden bool výraz a zároveň druhý bool výraz musí být true, aby byl výsledek true
            // || (RAlt + W) znamená nebo...jeden bool výraz nebo druhý bool výraz musí být true (nebo oba), aby byl výsledek true



            /*if(((nahodna1 % 2 == 0) && (nahodna2 % 2 == 0) && (nahodna3 % 2 == 0)) || ((nahodna1 % 2 != 0) && (nahodna2 % 2 != 0) && (nahodna3 % 2 != 0)))
            {
                return true;
            }*/


            if ((nahodna1 % 2 == 0) && (nahodna2 % 2 == 0) && (nahodna3 % 2 == 0))
            {
                return true;
            }
            else if ((nahodna1 % 2 != 0) && (nahodna2 % 2 != 0) && (nahodna3 % 2 != 0))
            {
                return true;
            }
            //zde už nemusí být else {return false;}, protože máme na konci return false, který se vykoná, pokud ani jedna podmínka není platná

            return false;
        }

        static void Menu()
        {
            Console.WriteLine("1 - Jedna kostka");
            Console.WriteLine("2 - Součet dvou kostek");
            Console.WriteLine("3 - Všechny sudé nebo všechny liché");

            string hodnotaUzivatele = Console.ReadLine();

            if (hodnotaUzivatele == "1")
            {
                Console.WriteLine("Na kostce padla hodnota: " + HodKostkou());
            }
            else if (hodnotaUzivatele == "2")
            {
                Console.WriteLine("Součet hodu dvou kostek je: " + HodDvemaKostkami());
            }
            else if (hodnotaUzivatele == "3")
            {
                //zde by Console.WriteLine vypsala jen true nebo false a uživatel by nevěděl proč.
                //Proto výsledek funkce využijeme pro rozhodnutí v if pro vypsání vlastní hlášky.
                if (HodTremiKostkami() == true)
                {
                    Console.WriteLine("Všechny jsou zároveň sudé nebo všechny jsou zároveň liché");
                }
                else
                {
                    Console.WriteLine("Některé jsou sudé, některé liché");
                }
            }
            else
            {
                Console.WriteLine("Byl zadán nesmysl");
            }

            Console.WriteLine();
        }
    }
}
