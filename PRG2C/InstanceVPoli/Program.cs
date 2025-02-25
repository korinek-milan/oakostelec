using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVPoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Zubák", PovoleneZvire.Stegosaurus);
            Animal a2 = new Animal("Pes", PovoleneZvire.Pes);
            Animal a3 = new Animal("Kočka", PovoleneZvire.Kocka);

           // Console.WriteLine(PovoleneZvire.Pes.ToString());

            PovoleneZvire p;
            Enum.TryParse<PovoleneZvire>("Kocka", out p);
            Console.WriteLine(p.ToString());
            Enum.TryParse<PovoleneZvire>("Kočka", out p);
            Console.WriteLine(p.ToString());


            //Console.WriteLine(a1.vypisInfo()) ;
            int x = 42;

            int[] pole = new int[6];
            int[] p2 = { x, 4, 99 };

            Animal[] mojePole = new Animal[5];
            
            Animal[] poleZvirat = new Animal[6];
            Animal[] poleZvirat2 = { a1, a2, a3 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(p2[i]);
            }

            for (int i = 0; i < poleZvirat2.Length; i++)
            {
                Animal a = poleZvirat2[i];
                Console.WriteLine(a.vypisInfo());
            }

            //for (int i = 0; i < 6; i++)
            //{
            //    int cislo = 5;
            //    Animal a = new Animal(i.ToString());
            //    poleZvirat[i] = a;
            //}

            foreach (Animal mojeLokalniZvire in poleZvirat2)
            {
                Console.WriteLine(mojeLokalniZvire.vypisInfo());
            }


            //cislo = 1;
            //a.vypisInfo();

            //for (int i = 0; i < poleZvirat.Length; i++)
            //{
            //    Console.WriteLine(poleZvirat[i].vypisInfo());
            //}

        }
    }
}
