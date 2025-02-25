using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fronta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Front f = new Front();

            f.Push(5);
            f.Push(1);
            f.Push(4);
            f.Push(7);

            //mohu dát .Value, protože Pop() mi vrací uzel a já se toho vráceného uzlu zrovna dotážu na Value
            //Po tomto už bude pouze fronta 1,4,7
            Console.WriteLine(f.Pop().Value);
            
            //Po tomto bude stále fronta 1,4,7
            Console.WriteLine(f.Peek());
        }
    }
}
