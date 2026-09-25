namespace HadaniCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rozšíření - náhodné číslo

            Random generatorCisel = new Random();


            int tajneCislo = generatorCisel.Next(1, 11);

            Console.WriteLine("zde podvádím:" + tajneCislo);
            //for - daný počet opakování
            //while - neznáme dopředu kolikrát proběhne

            //i = i +1

            Console.WriteLine("Zadej, kolikrát chceš hádat");
            int kolikrat;
            bool povedloSe = int.TryParse(Console.ReadLine(), out kolikrat);

            if (povedloSe == false)
            {
                Console.WriteLine("Byl zadán nesmysl, nastavuji defaultně na 5 pokusů");
                kolikrat = 5;
            }


            for (int i = 1;i<=kolikrat;i++)
            {
                //2. číslo od uživatele -> hláška uživateli, co má dělat
                Console.WriteLine("Hádej číslo od 1 do 10");
                //3. Uložení čísla od uživatele + přetypování + kontrola, že nezadává nějaký nesmysl, např. text
                //int cisloOdUzivatele = Convert.ToInt32(Console.ReadLine());//tohle nefunguje s textem

                //pokud o přetypování, výsledek pokusu se uloží do proměnné typu bool - povedloSe
                int cisloOdUzivatele;
                povedloSe = int.TryParse(Console.ReadLine(), out cisloOdUzivatele);

                
                if (povedloSe == true)
                {
                    //6. porovnání tajného čísla s číslem uživatele
                    if (tajneCislo == cisloOdUzivatele)
                    {
                        //7. výpis hlášky
                        //Console.WriteLine("Uhádli jste na" + " "+ i + " pokus");stringy spojuji přes plus
                        //lepší varianta z pohledu přehlednosti - přidám dolar před uvozovky a pak používám proměnné ve složených závorkách
                        Console.WriteLine($"Uhádli jste na {i} pokus");


                        //i = 5;mohu ukončit cyklus tak, že posunu index na konec
                        break;//okamžitě ukončí cyklus nezávisle na podmínce - zde se to hodí, aby uživatel dál nehádal, když už uhodl
                        //continue; používá se v případě, že chceme ukončit aktuální iteraci
                    }
                    else
                    {
                        //7. výpis hlášky
                        Console.WriteLine("Neuhádli jste");
                    }
                }
                else
                {
                    Console.WriteLine("Špatně zadaná hodnota");
                }
            }


        }
    }
}
