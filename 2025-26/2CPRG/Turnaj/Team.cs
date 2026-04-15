using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnaj
{
    internal class Team
    {
        public bool hasLost { get; private set; } = false;
        public string Nazev { get; private set; }

        public void nastavHasLost()
        {
            hasLost = true;
        }
    }
}
