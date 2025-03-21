using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    internal class Knihovna
    {
        public List<Kniha> knihy = new List<Kniha>();

        public void pridejKnihu(Kniha k)
        {
            knihy.Add(k);
        }
    }
}
