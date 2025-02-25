using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DynamickaStruktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList l = new MyLinkedList();
            l.Add(42);
            l.Add(1);

            Console.WriteLine(l.Print());

        }
    }
}
