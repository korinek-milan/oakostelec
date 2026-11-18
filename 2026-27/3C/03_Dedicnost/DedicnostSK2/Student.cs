using System;
using System.Collections.Generic;
using System.Text;

namespace DedicnostSK2
{
    internal class Student : Osoba
    {
        List<string> studovanePredmety = new List<string>();
        bool Studuje;

        public Student(string jmeno, bool studuje) : base(jmeno)
        {
            Studuje = studuje;
        }

        public void OdpovezNaOtazku()
        {
            Console.WriteLine("Odpovězeno");
        }
    }
}
