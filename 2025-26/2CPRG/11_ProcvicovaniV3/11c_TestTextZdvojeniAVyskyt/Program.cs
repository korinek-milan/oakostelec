using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTextZdvojeniAVyskyt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextMaker.kolikrat('a',"ahoj"));
            Console.WriteLine(TextMaker.zdvoj("ahoj"));
        }
    }
}
