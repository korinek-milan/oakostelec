using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knihovna kostelecka = new Knihovna();
            Knihovna castolovicka = new Knihovna();
            string Name = "random text";

            Kniha knihaPrvni = new Kniha(1, "Zaklínač", "Sapkowski");
            Console.WriteLine(knihaPrvni.vratInfo());
            knihaPrvni.PrejmenujSe("Ucebnice matematiky");
            castolovicka.pridejKnihu(knihaPrvni);

            Kniha knihaDruha = new Kniha(2, "Učebnice češtiny", "Novák");
            castolovicka.pridejKnihu(knihaDruha);

            Kniha knihaTreti = new Kniha(3, "Havran", "E. A. Poe");

            kostelecka.pridejKnihu(knihaTreti);


            Ekniha Ekniha1 = new Ekniha(4, "Ekn1", "nějaký auutor 1", 5);
            Ekniha Ekniha2 = new Ekniha(5, "Ekn2", "Nějaký autor 2", 11);

            //
            castolovicka.pridejKnihu(Ekniha1);
            castolovicka.pridejKnihu(Ekniha2);

            foreach (Kniha lokalniKniha in castolovicka.knihy)
            {
                Console.WriteLine(lokalniKniha.vratInfo());

                //toto nejde,kniha SizeMB nezná
                //Console.WriteLine(lokalniKniha.SizeMB);
            }
        }
    }
}
