using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = new int[10];

            Random r = new Random();
            for (int i = 0; i < hodnoty.Length; i++)
            {
                hodnoty[i] = r.Next(0, 11);
            }

            int hodnota;
            int aktualniCetnost = 0;
            int nejvyssiCetnost = 0;
            int nalezenaHodnota = hodnoty[0];

            foreach (int i in hodnoty)
            {
                Console.Write(i + " ");
            }

            for (int i = 0; i < hodnoty.Length; i++)
            {
                hodnota = hodnoty[i];
                aktualniCetnost = 0;
                for (int j = 0; j < hodnoty.Length; j++)
                {
                    if (hodnoty[j] == hodnota)
                    {
                        aktualniCetnost++;
                    }
                }

                if (nejvyssiCetnost < aktualniCetnost)
                {
                    nalezenaHodnota = hodnota;
                    nejvyssiCetnost = aktualniCetnost;
                }
            }

            Console.WriteLine($"Modus: {nalezenaHodnota} s četností {nejvyssiCetnost}");
        }
    }
}
