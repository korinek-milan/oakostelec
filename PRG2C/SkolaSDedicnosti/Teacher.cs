using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaSDedicnosti
{
    internal class Teacher: Osoba
    {
        public Teacher(int _AgeUcitele, string _NameUcitele) : base(_AgeUcitele, _NameUcitele)
        {
            //Console.WriteLine("Konstruktor studenta");
        }

        public string gradeHomework()
        {
            return "Opravuji domácí úkoly";
        }
    }
}
