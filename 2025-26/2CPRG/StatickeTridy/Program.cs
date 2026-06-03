using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickeTridy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            int b = 7;

            //statická třída její volání přímo přes název třídy
            Console.WriteLine(Kalkulacka.scitani(a, b));
            Console.WriteLine(Kalkulacka.ulozeneCislo);

            //klasická instance
            Student s1 = new Student("Karel");
            Student s2 = new Student("Jirka");

            Console.WriteLine(s1.jmeno);
            //instance nemá přístupné statické atributy, proto se jich ani nemůže dotázat..nedává to ani smysl
            //student s1 nemá důvod mít informaci o počtu studentů celkem
            //s1.pocetVytvorenychStudentu
            Console.WriteLine(Student.pocetVytvorenychStudentu);

            Console.WriteLine(Student.vratPocetStudentu());
        }
    }
}
