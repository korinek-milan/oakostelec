using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsorted = new int[10];

            //trida Random vraci nahodne hodnoty
            Random rnd = new Random();
            for (int i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = rnd.Next(0,255);//next mi vypise dalsi nahodne cislo, parametry jsou <minimum, maximum)
            }

            foreach (int num in unsorted)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();

            int[] sorted = SelectSortFn(unsorted);

            foreach (int num in sorted)
            {
                Console.Write(num + ",");
            }

            Console.ReadLine();
        }

        public static int[] SelectSortFn(int[] unsorted)
        {
            //prvni cyklus mi zamyka serazenou cast
            //zacinam na prvni pozici i = 0
            //kdyz projede hledani minima a pripadna vymena, v dalsim cyklu uz hledam od pozice 2 (index 1) -> prvni cyklus 0 -> 1
            for(int i = 0;i < unsorted.Length;i++)
            {
                int index = i;
                //tento cyklus prochazi cely zbytek neserazeneho pole a hleda minimum
                for (int j = i;j<unsorted.Length;j++)
                {
                    if (unsorted[j] < unsorted[index])
                    {
                        //ulozim si pozici minima
                        index = j;
                    }
                }
                //prohodim nalezenou nejmensi pozici unsorted[index] s prvni pozici neserazeneho pole unsorted[i]
                //na prohozeni dvou hodnot musim pouzit pomocnou promennou, abych si tu puvodne nesmazal
                int tmp = unsorted[i];
                unsorted[i] = unsorted[index];
                unsorted[index] = tmp;
            }

            //zde jiz je pole serazene
            return unsorted;
        }
    }
}

