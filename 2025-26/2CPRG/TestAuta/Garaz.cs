using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAuta
{
    internal class Garaz
    {
        public List<Auto> seznamAut { get; private set; } = new List<Auto>();

        public void pridejAuto(Auto a)
        {
            seznamAut.Add(a);
        }

        public int pocetAutVGarazi()
        {
            return seznamAut.Count;
        }
    }
}
