using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Řazení
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = { 3, 5, 4, 2, 468, 51, 3, 57, 4, 52, 46, 38, 5, 4, 6, 3 };

            int[] mySortedArray = new int[randomArray.Length];
            mySortedArray = sort(randomArray);

            Console.WriteLine("-------finalni podoba pole-------");
            printArray(mySortedArray);
            Console.ReadLine();
        }

        public static int[] sort(int[] unsortedArray)
        {
            int j = unsortedArray.Length - 2;
            int temp;
            // kontrola prohozeni
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i <= j; i++)
                {
                    Console.WriteLine("i = {0}", i);
                    // prohozeni
                    printArray(unsortedArray);
                    if (unsortedArray[i] > unsortedArray[i + 1])
                    {
                        temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i + 1];
                        unsortedArray[i + 1] = temp;
                        swapped = true;
                        Console.WriteLine("-----sort----");
                        printArray(unsortedArray);
                        Console.WriteLine("-----end----");
                    }
                }
                Console.WriteLine("konec for cyklu");
                if (swapped)
                {
                    Console.WriteLine("nejake prohozeni probehlo, proto pokracujeme od zacatku");
                }
                else
                {
                    Console.WriteLine("zmena neprobehla, koncime");
                }
                //j--;
            }

            return unsortedArray;
        }

        public static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i+",");
            }
            Console.WriteLine();
        }
    }
}
