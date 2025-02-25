using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PorovnaniRazeni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] unsorted = new int[100000];
            int[] sorted = new int[unsorted.Length];
            Random rnd = new Random();
            for (int i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = rnd.Next(0, 100000);//next mi vypise dalsi nahodne cislo, parametry jsou <minimum, maximum)
            }

            Stopwatch swq = new Stopwatch();
            swq.Start();
            sorted = quickSort(unsorted);
            swq.Stop();
            Console.WriteLine("QuickSort={0}", swq.Elapsed);

            Stopwatch sws = new Stopwatch();
            sws.Start();
            sorted = SelectSortFn(unsorted);
            sws.Stop();
            Console.WriteLine("SelectSort={0}", sws.Elapsed);

            Stopwatch swa = new Stopwatch();
            swa.Start();
            Array.Sort(unsorted);
            swa.Stop();
            Console.WriteLine("Array.Sort()={0}", swa.Elapsed);

            Console.WriteLine("\nTest with already sorted array\n");

            //obsahuje asi chybu
            //Stopwatch swqs = new Stopwatch();
            //swqs.Start();
            //sorted = quickSort(unsorted);
            //swqs.Stop();
            //Console.WriteLine("QuickSortSorted={0}", swqs.Elapsed);

            Stopwatch swss = new Stopwatch();
            swss.Start();
            sorted = SelectSortFn(unsorted);
            swss.Stop();
            Console.WriteLine("SelectSortSorted={0}", swss.Elapsed);

            Stopwatch swas = new Stopwatch();
            swas.Start();
            Array.Sort(unsorted);
            swas.Stop();
            Console.WriteLine("Array.Sort()Sorted={0}", swas.Elapsed);

            Console.ReadLine();

        }

        public static int[] SelectSortFn(int[] unsorted)
        {
            //prvni cyklus mi zamyka serazenou cast
            //zacinam na prvni pozici i = 0
            //kdyz projede hledani minima a pripadna vymena, v dalsim cyklu uz hledam od pozice 2 (index 1) -> prvni cyklus 0 -> 1
            for (int i = 0; i < unsorted.Length; i++)
            {
                int index = i;
                //tento cyklus prochazi cely zbytek neserazeneho pole a hleda minimum
                for (int j = i; j < unsorted.Length; j++)
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

        public static int[] quickSort(int[] unsorted)
        {

            if (unsorted.Length == 1)
            {
                return unsorted;
            }

            int[] sorted = new int[unsorted.Length];

            int pivot = unsorted[unsorted.Length - 1];


            int maxIndex = unsorted.Length - 2;

            int lesserPointer = maxIndex;
            int biggerPointer = 0;

            bool biggerFound = false;
            bool lesserFound = false;

            while (biggerPointer <= lesserPointer && biggerPointer < maxIndex)
            {
                if (biggerFound == false)
                {
                    if (unsorted[biggerPointer] > pivot)
                    {
                        biggerFound = true;
                    }
                    else
                    {
                        biggerPointer++;
                    }
                }


                if (lesserFound == false)
                {
                    if (unsorted[lesserPointer] < pivot)
                    {
                        lesserFound = true;
                    }
                    else
                    {
                        lesserPointer--;
                    }

                }


                if (biggerFound && lesserFound)
                {
                    int tmp = unsorted[biggerPointer];
                    unsorted[biggerPointer] = unsorted[lesserPointer];
                    unsorted[lesserPointer] = tmp;

                    lesserFound = false;
                    biggerFound = false;
                    biggerPointer++;
                    lesserPointer--;
                }

                if (biggerPointer > lesserPointer)
                {
                    sorted[biggerPointer] = pivot;
                    unsorted[unsorted.Length - 1] = unsorted[biggerPointer];
                    unsorted[biggerPointer] = pivot;
                    break;
                }
            }


            int[] smaller = new int[lesserPointer + 1];
            int[] bigger = new int[maxIndex + 1 - biggerPointer];

            for (int i = 0; i < lesserPointer + 1; i++)
            {
                smaller[i] = unsorted[i];
            }

            for (int i = 0; i < bigger.Length; i++)
            {
                bigger[i] = unsorted[i + biggerPointer + 1];
            }

            if (smaller.Length > 0)
            {
                smaller = quickSort(smaller);
                for (int i = 0; i < lesserPointer + 1; i++)
                {
                    sorted[i] = smaller[i];
                }
            }

            sorted[lesserPointer + 1] = pivot;

            if (bigger.Length > 0)
            {
                bigger = quickSort(bigger);
                for (int i = 0; i < bigger.Length; i++)
                {
                    sorted[i + biggerPointer + 1] = bigger[i];
                }
            }

            return sorted;
        }
    }
}
