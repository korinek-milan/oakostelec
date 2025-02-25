using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalVsGlobalSpace
{
    internal class Program
    {
        static int x;
        static int y;
        static int z;
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte hodnotu x:");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("zadejte hodnotu y:");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("zadejte hodnotu z:");
            z = Int32.Parse(Console.ReadLine());

            int vysledek;
            myFunc(out vysledek);

            Console.WriteLine("vysledek: {0}", vysledek);
            Console.ReadLine();
        }

        static void myFunc(out int _vysledek)
        {
            _vysledek = x * y * z;
        }
    }
}
