using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnaj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tournament t = new Tournament("Uzasny turnaj");
            //vytvoření hráčů
            //vytvoření týmu
            //přidání týmu do turnaje

            while (t.getWinner() == "Turnaj ještě není dohraný")
            {
                t.CreateAndPlaGame1();
            }

            Console.WriteLine(t.getWinner()); ;

        }
    }

}
