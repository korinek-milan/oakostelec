using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VodniNadrz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VodniNadoba v1 = new VodniNadoba(100);
            v1.pridejVodu(5);
            v1.pridejVodu(2.5);
            Console.WriteLine(v1.KolikJeVody());
        }
    }
}
