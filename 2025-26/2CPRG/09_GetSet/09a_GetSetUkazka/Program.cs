using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUkazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boty b1 = new Boty(100, "Nike");
            Boty b2 = new Boty(250, "Adidas");


            //díky get/set si program sám rozhodne, jestli chci číst nebo zapisovat
            Console.WriteLine(b1.Nazev);
            b1.Nazev = "abc";

            Sklad s = new Sklad();
            s.pridejDoSeznamu(b1);
            s.pridejDoSeznamu(b2);

            Console.WriteLine(s.vypisVsechnyCeny());

            foreach (double item in s.vratVsechnyCeny())
            {
                Console.WriteLine(item);
            }

            foreach (Boty item in s.vratBotyNaSklade())
            {
                Console.WriteLine(item.vratCenu());
            }

        }
    }
}
