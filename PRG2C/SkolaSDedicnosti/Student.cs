using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkolaSDedicnosti
{
    internal class Student: Osoba
    {
        //na vstupu konstruktoru student potřebuji nějakou hodnotu
        //Tu následně vezmu a pošlu ji přes base do rodičovského konstruktoru, který pomocí ní naplní atributy
        public Student(int _AgeStudenta, string _NameStudenta): base(_AgeStudenta, _NameStudenta)
        {
        }

        public string WriteHomework()
        {
            return "Píšu domácí úkol";
        }
    }
}
