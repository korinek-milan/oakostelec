using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ovoce o1 = new Ovoce();//neurčité náhodné ovoc
            Ovoce o2 = new Ovoce("hruška", 10);

            Kosik k = new Kosik();
            k.pridejOvoce(o1);
            k.pridejOvoce(o2);

            Console.WriteLine(k.soucetHmotnosti());
        }

    }
}
