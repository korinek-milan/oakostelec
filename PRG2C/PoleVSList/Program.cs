using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoleVSList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //připravím si prázdné pole o velikosti 5
            int[] cisla = new int[5];

            //připravím si pole o velikosti 4 a hned naplním 4 hodnotami
            int[] cisla2 = { 4, 2, 5, 4 };
            
            //přidám hodnotu na index 2
            cisla[2] = 0;

            //vytvořím si list na inty a neřeším velikost
            List<int> myList = new List<int>();
            //přidávám prvky
            myList.Add(5);
            myList.Add(42);
            myList.Add(2);
            myList.Add(4);
            myList.Add(50);

            //procházení foreachem
            //int i je lokální proměnná kam si foreach uloží jednu položku z listu
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            //klasické procháízení forcyklem
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            



        }
    }
}
