using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyZviratDedicnost
{
    internal class Animal
    {
        int Age;
        string Name;

        public Animal(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }

        public string getInfo()
        {
            return $"Jmenuji se: {Name} a je mi {Age}";
        }

        public virtual string makeSound()
        {
            return "univerzální zvuk";
        }
    }
}
