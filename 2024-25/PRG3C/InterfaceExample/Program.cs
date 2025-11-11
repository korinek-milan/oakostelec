using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal kachna = new Animal();

            kachna.Fly();  // Kachna létá.
            kachna.Swim(); // Kachna plave.

            Animal a = new Animal();
            Animal b = new Animal();

            IFlyable racek = a;
            racek.Fly();
            //racek.Swim();//toto neni mozne, protoze IFlyable nezná

            ISwimmable pes = b;
            pes.Swim();
            //pes.Fly();//toto opet neni mozne, protože Fly v ISwimmable neexistuje
        }
    }

    public class Animal : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("létá.");
        }

        public void Swim()
        {
            Console.WriteLine("plave.");
        }
    }
}
