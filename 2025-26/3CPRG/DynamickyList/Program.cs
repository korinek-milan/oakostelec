using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamickyList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> l1 = new List<int>();

            MyList l = new MyList();
            l.Add(42);
            l.Add(11);
            l.Add(5);

            l.Remove(11);
        }
    }
}
