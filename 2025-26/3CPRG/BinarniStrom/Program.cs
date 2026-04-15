using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarniStrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>();
            s.Add("abc");

            Strom t = new Strom();
            t.Add(5);
            t.Add(1);
            t.Add(2);
            t.Add(3);
        }
    }
}
