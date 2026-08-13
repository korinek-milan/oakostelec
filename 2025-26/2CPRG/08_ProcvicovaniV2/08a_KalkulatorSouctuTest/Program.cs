using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorSouctuTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] pole = new double[5];

            for (int i = 0; i < pole.Length; i++)
            {
                double x = 0;
                Console.WriteLine("Zadej číslo");
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    pole[i] = x;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Není číslo");
                    i--;
                }
            }

            Kalkulator k = new Kalkulator();
            Console.WriteLine(k.SpocitejSoucet(pole));

        }
    }
}
