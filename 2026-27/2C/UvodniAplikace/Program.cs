namespace UvodniAplikace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celeCislo = 5;
            double desetinneCislo = 3.14;
            char jedenZnak = 'h';
            string nejakyPrazdnyText = "";
            string nejakyText = "slovo i s mezerou";
            bool jePravda = true;//false

            //WriteLine - samo udělá enter
            Console.WriteLine(celeCislo);

            //Write - píše na jeden řádek, dokud si neřeknu o enter
            Console.Write(celeCislo);
            Console.Write(nejakyText);
            Console.Write("\r\n");//speciální symbol pro nový řádek
            Console.WriteLine("text na novém řádku");
            Console.WriteLine();//bez textu udělá pouze nový řádek

            /*
            tady
            je
            nějaky
            víceřádkový
            komentář
            */

            int prvniCislo = 5;
            int druheCislo = 10;
            int soucet = prvniCislo + druheCislo;
            Console.WriteLine(soucet);


            /*
            Console.WriteLine("Zadej svoje jméno");//uživateli vždy napíšu, co po něm chci
            string textovyVstupOdUzivatele = Console.ReadLine();//čte text z konzole, neumí říct uživateli, co má zadat, proto mu to musíme napsat sami o řádek výš
            Console.WriteLine("Vaše jméno je: " + textovyVstupOdUzivatele);//spojování stringů přes znak plus
            */

            /*Console.WriteLine("Budeme sčítat dvě čísla, zadej první číslo");
            double Cislo1 = Convert.ToDouble(Console.ReadLine()) ;

            Console.WriteLine("Zadejte druhé číslo");
            string textoveCislo2 = Console.ReadLine();
            double Cislo2 = Convert.ToDouble(textoveCislo2);


            Console.WriteLine("Součet čísel je:" + (Cislo1 + Cislo2));
            */

            //jiny způsob přetypování
            double nejakeCislo;
            //tato konverze funguje tak, že do druhé proměnné s příznakem out se pokusí uložit přetypované číslo
            //výstupem funkce není přetypované číslo jako u Conver.to...ale je to true / false - informace o tom, jestli se to povedlo přetypovat
            bool povedloSe = Double.TryParse(Console.ReadLine(), out nejakeCislo);

            //informaci o úspěšnosti mohu použít na vypsání informace pro uživatel, jestli se to povedlo nebo ne
            //uvnitř if musí být hodnota true nebo false...tzn. buď porovnání nebo bool hodnota
            if (povedloSe == true)//lze napsat i zkrácenou variantu if(povedloSe)
            {
                Console.WriteLine(5 + nejakeCislo);
            }
            else
            {
                Console.WriteLine("Přetypování se nepovedlo, proto nebudu nic sčítat");
            }

            
        }
    }
}
