using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyZviratDedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tohle funguje, ale nechci obecné zvíře
            Animal a = new Animal("Neurčité zvíře", -1);
            Console.WriteLine(a.getInfo());
            Console.WriteLine(a.makeSound());

            Cat c = new Cat("Míca", 10);
            Console.WriteLine(c.getInfo());
            Console.WriteLine(c.makeSound());
            Console.WriteLine(c.Climb());

            Cat c2 = new Cat("Jiná míca", 42);

            List<Animal> animals = new List<Animal>();
            animals.Add(c);
            animals.Add(c2);

            foreach(Animal zvire in animals)
            {
                Console.WriteLine(zvire.getInfo());
                Console.WriteLine(zvire.makeSound());

                //toto třída Animal neumí, i když je zde schovaná kočka
                //Console.WriteLine(zvire.Climb());
            }
        }
    }
}
