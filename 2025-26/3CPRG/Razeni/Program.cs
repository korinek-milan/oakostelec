using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] unsorted = new int[10];
            Random r = new Random();
            for (int i = 0;i<unsorted.Length;i++)
            {
                unsorted[i] = r.Next(10);
            }
            vypisPole(unsorted);

            for (int i = 0;i < unsorted.Length; i++)
            {
                for (int j = 0; j < unsorted.Length-1; j++)
                {
                    int tmp = unsorted[j];
                    if (unsorted[j] > unsorted[j+1])
                    {
                        unsorted[j] = unsorted[j+1];
                        unsorted[j+1] = tmp;
                    }
                }
            }

            vypisPole(unsorted);

        }

        public static void vypisPole(int[] pole)
        {
            foreach (int i in pole)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
