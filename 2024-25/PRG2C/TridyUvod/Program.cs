using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyUvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            //Nova instance datoveho typu Clovek, vcetne naplneni hodnot pomoci konstruktoru
            Clovek Karel = new Clovek("hnede", 180, 10000, true);
            Clovek Jonas = new Clovek("zelene", 200 , 200, false);

            Karel.nastavVek(100);

            //dotazuji se promenne Karel na jeho verejne metody - zde nastavVek, kde na vstupu je nejake cislo
            Jonas.nastavVek(i);

            //Zde mohu pouzivat Console.WriteLine
            Console.WriteLine("Karel: " + Karel.jeZivy().ToString());
            Console.WriteLine("Jonas: " + Jonas.jeZivy().ToString());

            Console.WriteLine(sctitani(5, 4));

            Console.ReadLine();
        }

        public static int sctitani(int a, int b)
        {
            return a + b;
        }

    }
}
