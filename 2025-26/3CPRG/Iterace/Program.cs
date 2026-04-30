using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[42];

            for (int i = 0; i < 10;i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            while (true)
            {


                //if (uzivatel zadal konec)
                {
                    break;
                }
            }


            //proběhned vždy alespoň 1x -> vyhodnocuje se až na konci
            int n = 10;
            do
            {
                Console.Write(n);
                n++;
            } while (n < 5);

            List<string> s = new List<string>() {"x", "y", "z" };
            
            int pozice = 0;
            foreach (string item in s)
            {
                //vypiš na kterém indexu je hodnota "y"
                if (item == "y")
                {
                    Console.WriteLine(pozice);
                    break;
                }
                Console.WriteLine(item);
                pozice++;
            }

            foreach (string item in s)
            {
                if (item == "y")
                {
                    s.Add("něco");
                    //pozor na to, že když změním strukturu, nesmím pokračovat ve foreach
                    break;
                }
                Console.WriteLine(item);
            }

            foreach (int item in pole)
            {

            }

            //můžu mít list jakéhokoliv datového typu - i instance (např. ovoce)
            List<Ovoce> kosik = new List<Ovoce>();

            foreach (Ovoce item in kosik)
            {

            }

        }
    }
}
