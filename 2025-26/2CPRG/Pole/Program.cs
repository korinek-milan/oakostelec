using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int[] poleIntu = new int[10];
            string[] poleStringu = { "jablko", "hruška", "švestka", "meloun" };

            //Console.WriteLine(poleStringu[1]);

            for (int i = 0; i < poleStringu.Length; i++)
            {
                Console.WriteLine($"{poleStringu[i]} je na indexu {i}");
                //Console.WriteLine(poleStringu[i] + "je na indexu " + i);
            }

            foreach (string prvek in poleStringu)
            {
                Console.WriteLine(prvek);
            }

            poleIntu[3] = 42;
            //poleStringu[4] = "třešeň";

            Random r = new Random();
            for (int i = 0; i < poleIntu.Length; i++)
            {
                poleIntu[i] = r.Next();
            }

            
            

        }
    }
}
