using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TridyZviratDedicnost
{
    internal class Cat: Animal
    {
        public Cat(string _NameKočky, int _AgeKocky) : base(_NameKočky, _AgeKocky)
        {
        }

        public string Climb()
        {
            return "Kočka šplhá po stromě";
        }

        public override string makeSound()
        {
            //mohu požádat rodičovskou třídu, ať vykoná svoji metodu pomocí base
            //return "mňau " + base.makeSound();

            //zahodil jsem, co dělá rodič a přepsal si to podle sebe
            return "mňau";
        }

    }
}
