using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsorted = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = rnd.Next(0, 255);//next mi vypise dalsi nahodne cislo, parametry jsou <minimum, maximum)
            }

            int[] sorted = quickSort(unsorted);

            foreach (int i in sorted)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

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

            while (biggerPointer <= lesserPointer)
            {
                if (biggerFound == false)
                {
                    if(unsorted[biggerPointer] > pivot)
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
                    if(unsorted[lesserPointer] < pivot)
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


            int[] smaller = new int[lesserPointer+1];
            int[] bigger = new int[maxIndex+1 - biggerPointer];

            for (int i = 0; i < lesserPointer+1; i++)
            {
                smaller[i] = unsorted[i];
            }

            for (int i = 0; i < bigger.Length; i++)
            {
                bigger[i] = unsorted[i+biggerPointer+1];
            }

            if(smaller.Length>0)
            {
                smaller = quickSort(smaller);
                for (int i = 0; i < lesserPointer+1; i++)
                {
                    sorted[i] = smaller[i];
                }
            }

            sorted[lesserPointer + 1] = pivot;

            if (bigger.Length > 0)
            {
                bigger = quickSort(bigger);
                for (int i = 0; i<bigger.Length; i++)
                {
                    sorted[i + biggerPointer + 1] = bigger[i];
                }
            }

            return sorted;
        }
    }
}
