using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaEF
{
    internal class Regal
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public List<Kniha> Knihy { get; set; }
    }
}
