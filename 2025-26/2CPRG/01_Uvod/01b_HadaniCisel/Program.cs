using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadaniCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int tajneCislo = r.Next(11);

            Console.WriteLine(tajneCislo);

            Console.WriteLine("hádej číslo od 0 do 10");
            string vstupOdUzivatele = Console.ReadLine();
            int prevedenyVstup = Convert.ToInt32(vstupOdUzivatele);

            // & right alt + C.......| right alt + W
            while ((tajneCislo != prevedenyVstup))
            {
                Console.WriteLine("Neuhodl jsi, hádej číslo od 0 do 10");
                vstupOdUzivatele = Console.ReadLine();
                prevedenyVstup = Convert.ToInt32(vstupOdUzivatele);

                if(nejaka podminka)
               {
                    break;
                }
        
            }

            Console.WriteLine("vyhrál");

            

        }
    }
}
