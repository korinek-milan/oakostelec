using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = 3;

            Console.WriteLine(fac(input));
            Console.ReadKey();

        }

        static double fac(double input)
        {
            if (input <= 1)
            {
                return 1;
            }
            else
            {
                return input * fac(input - 1);
            }

            //3! = 3 * 2!
            //2! = 2 * 1!

            //5! = 5 * 4!
            //4! = 4 * 3!
            //3 * 2 * 1

        }
    }
}
