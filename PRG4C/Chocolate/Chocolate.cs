using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    internal class Chocolate
    {
        public string Name { get; private set; }

        public Chocolate(string name)
        {
            Name = name;
        }
    }
}
