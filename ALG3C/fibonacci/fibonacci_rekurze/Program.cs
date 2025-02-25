using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_rekurze
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = 10;

            Console.WriteLine(fibonacci(input));
            Console.ReadLine();


        }

        //0 = 0
        //1 = 1
        //jinak Fn = (Fn-1) + (Fn-2)
        static int fibonacci(int input)
        {

            if (input == 0)
            {
                return 0;
            }
            else if (input == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(input - 1) + fibonacci(input - 2);
            }
        }
    }
}
