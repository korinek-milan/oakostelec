using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarovaSifra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Zadej slovo");
            string slovo = Console.ReadLine();
            Console.WriteLine("zadej posun");
            int posun = Convert.ToInt32(Console.ReadLine());*/
            Console.WriteLine(Sifrovac.sifrujORD("ABC", 2));
        }
    }
}
