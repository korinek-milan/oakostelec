using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaEF
{
    internal class Kniha
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int RegalId { get; set; }
        public Regal Regal { get; set; }
    }
}
