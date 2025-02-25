using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    internal class Ingredient
    {
        public string Name;
        public int Amount;

        public Ingredient(string _Name, int _Amount)
        {
            Name = _Name;
            Amount = _Amount;
        }
    }
}
