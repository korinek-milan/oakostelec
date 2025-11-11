using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            databaseManager dbm = new databaseManager();
            Console.WriteLine(dbm.nactiKnihy());
            Console.WriteLine(dbm.nactiKnihy());
            Console.WriteLine(dbm.nactiKnihy());

            //Kniha k2 = new Kniha("vytvoreny autor", "vytvoreny nazev", 1);

            //dbm.ulozKnihu(k2);

            Console.ReadLine();
        }
    }
}
