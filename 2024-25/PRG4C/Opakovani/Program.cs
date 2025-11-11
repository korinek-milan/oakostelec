using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej hodnotu pro uložení do databáze");
            int a;

            string myStr = "11";
            //dokud není splněná podmínka (číslo, které musí být 10), nech uživatele zadávat hodnotu
            while (!int.TryParse(Console.ReadLine(), out a) && a == 10)
            {
                Console.WriteLine("je to špatně, zkus to znova");
            }

            //string builder pro práci se stringem
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("abc");
            sb.Append("de");
            sb.AppendLine("f");

            //string builder je celá třída, kterou nemohu jen tak vypsat, proto potřebuji převést na string
            Console.WriteLine(sb.ToString());

            //moje instance
            MyClass m = new MyClass();
            //volání metod
            Console.WriteLine(m.myMethod());
            Console.WriteLine(m.getInfo());

            //do mé třídy jsem si přidal override ToString, takže mohu volat ToString na celou instanci (ale to není samozřejmost)
            Console.WriteLine(m.ToString());

        }
    }
}
