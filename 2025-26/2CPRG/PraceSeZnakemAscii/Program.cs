using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //jeden znak
            char c = '@';

            //string se skládá z jednotlivých charů
            string s = "ybc";

            //string je zároveň pole charů
            //následující řádek by vypsal znak b
            Console.WriteLine(s[1]);

            //přetypováním na int zjistím číselnou reprezentaci charu
            Console.WriteLine((int)c);
            //je jedno jakým způsobem přetypuji. Pro některé datové typy exituje rychlá varianta (nový datový typ)proměnnná
            Console.WriteLine(Convert.ToInt32(c));

            //přetypováním čísla na char zjistím, jaký znak odpovídá danému číslu
            Console.WriteLine((char)35);

            //při porovnávání nemusím přetypovat
            if (c == 64)
            {
                Console.WriteLine("je to zavináč");
            }
            else
            {
                Console.WriteLine("je to něco jiného");
            }
        }
    }
}
