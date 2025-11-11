using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pracovni prostor, ve kterem se pohybuji
namespace MujCelyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rucne vytvorim nekolik knih
            Kniha k1 = new Kniha("1984", "Orwell", 1949);
            Kniha k2 = new Kniha("Lord of the Rings", "Tolkien", 1954);
            Kniha k3 = new Kniha("Witcher", "Sapkowsky", 1993);

            EKniha k4 = new EKniha("Witcher e-book", "Sapkowsky", 1993, 20);

            int i = 0;
            
            //k1.oskliveInfo() //pro kontrolu
            //Console.WriteLine(k1.lepsiInfo());

            //rucne vytvorim novou knihovnu
            Knihovna knihovna = new Knihovna();
            //Console.ReadLine();
            //pridam kazdou existujici knizku
            knihovna.pridejKnihu(k1);
            knihovna.pridejKnihu(k2);
            knihovna.pridejKnihu(k3);
            knihovna.pridejKnihu(k4);

            //vypisu seznam knih
            knihovna.vypisKnihy();

            Console.ReadLine();
        }
    }
}
