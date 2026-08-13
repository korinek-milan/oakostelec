using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka k = new Kalkulacka();

            try
            {
                Console.WriteLine("Zadej dvě hodnoty pro dělení a první hodnota musí být větší než 10");
                Console.WriteLine(k.deleni(10, 2));
                //int[] pole = new int[10];
                //Console.WriteLine(pole[15]);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Nastala chyba v dělení nulou. Druhá zadaná hodnota nesmí být nula.");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("zadal jste větší množství hodnot než je požadováno");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nastala neočekávaná chyba");
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine("toto se vypíše na konci");
        }
    }
}
