using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //je úplně jedno, že uživateli řeknu, žek má zadat něco, může zadat cokoliv ...nulu, text...
            Console.WriteLine("Zadej číslo... POZOR!!! větší než nula");

            int cislo = 0;

            //bez try/catch ukončí program chybou
            //throw new Exception("chyba");

            //vše co je v try kontroluji na chyby
            try
            {
                cislo = Convert.ToInt32(Console.ReadLine());

                if (cislo == 0)
                {
                    //vyhazuji vlastní chybu s vlastní hláškou
                    //ale za cenu, že si sám musím zkontrolovat, že k ní dojde např. pomocí if
                    throw new DivideByZeroException("jsi osel, dělíš nulou");
                }


                double vypocet = 42 / cislo;
                Console.WriteLine(vypocet);
            }
            //konkrétní výjimka
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine("Nastalo dělení nulou, zadejte prosím hodnotu větší než 0");
                Console.WriteLine(ex.Message);
            }
            //konkrétní výjimka
            catch (FormatException ex)
            {
                Console.WriteLine("Zadaná hodnota není platná. Pravděpodobně jste nezadal číslo");
                //Console.WriteLine(ex.Message);
            }
            //pokud neplatí nic z předchozího, skočí do do této obecné výjimky
            catch (Exception ex)
            {
                Console.WriteLine("Nastala nějaká chyba");
                Console.WriteLine(ex.Message);
            }
            
            
            
            //program pokračuje dál, protože jsem úspěšně v try/catch odchytil potenciální chybu
            Console.WriteLine("Program se úspěšně ukončil");
            
            
        }
    }
}
