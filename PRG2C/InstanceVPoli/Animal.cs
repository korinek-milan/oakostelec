using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVPoli
{

    enum PovoleneZvire
    {
        Pes,
        Kocka,
        Stegosaurus,
    }

    internal class Animal
    {
        string name;
        PovoleneZvire povoleneZvire;
        
        public Animal(string name, PovoleneZvire z)
        { 
            this.name = name; 
            this.povoleneZvire = z;
        }

        public string vypisInfo()
            { return "Jméno: " + name; }

    }
}
